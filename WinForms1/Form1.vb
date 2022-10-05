Public Class frmPong
  Dim vx, vy As Single 'x and y vectors for ball
  Dim paddleZone As Integer 'section of paddle making contact with ball
  Dim winScore As Integer = 11 'score that must be attained to win game
  Dim scoreLeft, scoreRight, lastPoint As Integer 'game scores and last player to score
  Dim upFlag As Boolean = False 'True when left mouse button held down
  Dim dnFlag As Boolean = False 'True when right mouse button held down
  Dim breakCount As Integer = 0 'counter for tmrBreak clock ticks
  Dim intLCourt, intRcourt, intTCourt, intBCourt, intCCourt As Integer
  'left, right, top and bottom boundaries of court
  Dim intBallW, intBallH As Integer 'ball width and height
  Dim intPadLH, intPadRH As Integer 'left and right paddle heights
  Dim intPadLTop, intPadRTop As Integer 'initial y coordinate for top of paddles
  Dim intPadFaceL, intPadFaceR 'x coordinates for contact surfaces of left and right paddles

  Private Sub frmPong_Load(sender As Object, ByVal e As EventArgs) _
      Handles MyBase.Load
    'initialise global variables
    intLCourt = picPongTable.Left + 5
    intRcourt = picPongTable.Left + picPongTable.Width - 5
    intTCourt = picPongTable.Top + 5
    intBCourt = picPongTable.Top + picPongTable.Height - 5
    intCCourt = picPongTable.Left + picPongTable.Width / 2
    intBallW = lblBall.Width
    intBallH = lblBall.Height
    intPadLH = lblPaddleLeft.Height
    intPadRH = lblPaddleRight.Height
    intPadLTop = picPongTable.Top + picPongTable.Height / 2 - lblPaddleLeft.Height / 2
    intPadRTop = picPongTable.Top + picPongTable.Height / 2 - lblPaddleRight.Height / 2
    intPadFaceL = lblPaddleLeft.Left + lblPaddleLeft.Width
    intPadFaceR = lblPaddleRight.Left
  End Sub

  Private Sub tmrPaddle_Tick(sender As Object, ByVal e As EventArgs) _
    Handles tmrPaddle.Tick
    If lblBall.Left < (intCCourt - intBallW / 2) And vx < 0 Then
      'ball is in left court and moving towards left paddle
      If(lblBall.Top + intBallH / 2) >(lblPaddleLeft.Top + intPadLH / 2) Then
        'ball is below centre of left paddle
        If(lblPaddleLeft.Top + intPadLH) < intBCourt Then
          'paddle is not yet at at bottom of court
          lblPaddleLeft.Top += 4 'move left paddle down 4 pixels
        End If
      ElseIf(lblBall.Top + intBallH / 2) < (lblPaddleLeft.Top + intPadLH / 2) Then
        'ball is above centre of left paddle
        If lblPaddleLeft.Top > intTCourt Then 'paddle is not yet at top of court
          lblPaddleLeft.Top -= 4 'move left paddle up 4 pixels
        End If
      End If
    Else 'ball is not in left court or is moving away from left paddle
      If lblPaddleLeft.Top < intPadLTop Then
        'left paddle is above initial start position
        lblPaddleLeft.Top += 1 'move paddle down by 1 pixel
      ElseIf lblPaddleLeft.Top > intPadLTop Then
        'left paddle is below initial start position
        lblPaddleLeft.Top -= 1 'move paddle up by 1 pixel
      End If
    End If
    'make sure left paddle is between top and bottom borders of court
    If lblPaddleLeft.Top < intTCourt Then
      lblPaddleLeft.Top = intTCourt
    ElseIf lblPaddleLeft.Top >(intBCourt - intPadLH) Then
      lblPaddleLeft.Top =(intBCourt - intPadLH)
    End If

    If upFlag = True And lblPaddleRight.Top > intTCourt Then
      'left mouse button is down and left paddle is not at top of court
      lblPaddleRight.Top -= 4 'move right paddle up 4 pixels
    ElseIf dnFlag = True And lblPaddleRight.Top < (intBCourt - intPadRH) Then
      'right mouse button is down and left paddle is not at bottom of court
      lblPaddleRight.Top += 4 'move right paddle down 4 pixels
    End If
    'make sure right paddle is between top and bottom boundaries of court
    If lblPaddleRight.Top < intTCourt Then
      lblPaddleRight.Top = intTCourt
    ElseIf lblPaddleRight.Top >(intBCourt - intPadRH) Then
      lblPaddleRight.Top =(intBCourt - intPadRH)
    End If
  End Sub

  Private Sub tmrBall_Tick(sender As Object, ByVal e As EventArgs) _
    Handles tmrBall.Tick
    'this procedure moves the ball once per clock tick when the timer is turned on,
    'and checks the ball's position to see whether it has made contact with the top
    'or bottom boundaries of the court, made contact with a paddle, or reached the
    'left or right-hand end of the court
    lblBall.Top = lblBall.Top + vy 'move ball up or down by vy pixels
    lblBall.Left = lblBall.Left + vx 'move ball left or right by vx pixels
    If lblBall.Top < intTCourt Then lblBall.Top = intTCourt
      'keep ball below upper boundary of court
    If lblBall.Top >(intBCourt - intBallH) Then lblBall.Top =(intBCourt - intBallH)
      'keep ball above lower boundary of court
    If lblBall.Top <= intTCourt Or lblBall.Top >=(intBCourt - intBallH) Then vy = -vy
      'make ball "bounce"(change vertical direction of ball)
    If vx < 0 Then 'ball is moving from right to left
      If lblBall.Top >(lblPaddleLeft.Top - intBallH) And lblBall.Top _
        <(lblPaddleLeft.Top + intPadLH) Then
        'vertical coordinates of ball and left paddle overlap
        If lblBall.Left <= intPadFaceL Then 'ball has made contact with left paddle
          'change direction of ball and generate x and y vector values for ball
          'based on randon selection of paddleZone values (+3 to -3)
          Randomize()
          paddleZone = CInt((Rnd() * 6) - 3)
          Select Case paddleZone
            Case 3
              vy = -5
              vx = 2
            Case 2
              vy = -4
              vx = 3
            Case 1
              vy = -3
              vx = 4
            Case 0
              vy = 0
              vx = 5
            Case -1
              vy = 3
              vx = 4
            Case -2
              vy = 4
              vx = 3
            Case -3
              vy = 5
              vx = 2
          End Select
        End If
      Else
        If lblBall.Left <= intLCourt Then
          'vertical coordinates of ball and left paddle do not overlap
          'and ball has reached left boundary of court
          pointScored()
        End If
      End If
    ElseIf vx > 0 Then 'ball is moving from left to right
      If lblBall.Top > (lblPaddleRight.Top - intBallH) And lblBall.Top _
        < (lblPaddleRight.Top + intPadRH) Then
        'vertical coordinates of ball and right paddle overlap
        If(lblBall.Left + intBallW) > lblPaddleRight.Left Then
          'ball has made contact with right paddle
          getZoneR() 'get section of right paddle making contact with ball
          'change direction of ball and generate x and y vector values for ball
          'depending on calculated paddleZone value (+3 to -3)
          Select Case paddleZone
            Case 3
              vy = -5
              vx = -2
            Case 2
              vy = -4
              vx = -3
            Case 1
              vy = -3
              vx = -4
            Case 0
              vy = 0
              vx = -5
            Case -1
              vy = 3
              vx = -4
            Case -2
              vy = 4
              vx = -3
            Case -3
              vy = 5
              vx = -2
          End Select
        End If
      Else
        If lblBall.Left > (intRcourt - intBallW) Then
          'vertical coordinates of ball and right paddle do not overlap
          'and ball has reached right boundary of court
          pointScored()
        End If
      End If
    End If
  End Sub

  Private Sub tmrBreak_Tick(sender As Object, ByVal e As EventArgs) _
    Handles tmrBreak.Tick
    'this procedure executes when a point has been scored
    breakCount += 1 'record number of times timer has ticked
    If breakCount = 1 Then 'this is first timer tick
      lblPaddleLeft.Top = intPadLTop 'reset left paddle position
      lblPaddleRight.Top = intPadRTop 'reset right paddle position
      If lastPoint = 1 Then 'computer won last point
        lblBall.Top = lblPaddleLeft.Top + intPadLH / 2 - intBallH / 2
        'position ball in line with centre of left paddle
        lblBall.Left = intPadFaceL 'place ball immediately to right of left paddle
        vx = 5 'set ball's x vector value to 5
      ElseIf lastPoint = 2 Then 'player won last point
        lblBall.Top = lblPaddleRight.Top + intPadRH / 2 - intBallH / 2
        'position ball in line with centre of right paddle
        lblBall.Left = intPadFaceR - lblBall.Width
        'place ball immediately to left of right paddle
        vx = -5 'set ball's x vector value to -5
      End If
      'generate random y vector value for ball (5 to -5
      Randomize()
      vy = (Rnd() * 10) - 5
    ElseIf breakCount = 2 Then 'this is second timer tick
      breakCount = 0 'reset timer counter
      lblBall.Visible = True 'restore visibility of ball
      tmrBall.Start() 'restart tmrBall
      tmrPaddle.Start() 'restart tmrPaddle
      tmrBreak.Stop() 'stop tmrBreak
    End If
  End Sub

  Private Sub cmdPlay_Click(sender As Object, ByVal e As EventArgs) _
    Handles cmdPlay.Click
    'this procedure starts game - player will server first
    lblBall.Top = lblPaddleRight.Top + intPadRH / 2 - intBallH / 2
    'position ball in line with centre of right paddle
    lblBall.Left = intPadFaceR - lblBall.Width
    'place ball immediately to left of right paddle
    lblBall.Visible = True 'make ball visible
    vx = -5 'set ball's x vector to -5
    'generate random y vector value for ball (5 to -5)
    Randomize()
    vy = (Rnd() * 10) - 5
    tmrPaddle.Start() 'start tmrPaddle
    tmrBall.Start() 'start tmrBall
    cmdPlay.Enabled = False 'disable Start button
  End Sub

  Private Sub cmdPause_Click(sender As Object, ByVal e As EventArgs) _
    Handles cmdPause.Click
    'this procedure allows player to pause the game
    If cmdPause.Text = "Pause" Then 'game is in progress
      tmrPaddle.Stop() 'stop tmrPaddle
      tmrBall.Stop() 'stop tmrBall
      cmdPause.Text = "Resume" 'change button caption to "Resume"
    ElseIf cmdPause.Text = "Resume" Then 'game is paused
      tmrPaddle.Start() 'start tmrPaddle
      tmrBall.Start() 'start tmrBall
      cmdPause.Text = "Pause" 'change button caption to "Pause"
    End If
  End Sub

  Private Sub cmdReset_Click(sender As Object, ByVal e As EventArgs) _
    Handles cmdReset.Click
    'this procedure stops game and resets game variable and display
    reset()
    resetScores()
  End Sub

  Private Sub cmdExit_Click(sender As Object, ByVal e As EventArgs) _
    Handles cmdExit.Click
    'this procedure exits program immediately
    End
  End Sub

  Sub getZoneR()
    'this procedure checks where ball "made contact" with
    'rightPaddle and sets value of paddleZone accordingly
    'numbers would need adjustment if paddle height changed
    If(lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 10) Then
      paddleZone = 3
    ElseIf(lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 20) Then
      paddleZone = 2
    ElseIf(lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 30) Then
      paddleZone = 1
    ElseIf(lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 50) Then
      paddleZone = 0
    ElseIf(lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 60) Then
      paddleZone = -1
    ElseIf(lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 70) Then
      paddleZone = -2
    Else
      paddleZone = -3
    End If
  End Sub

  Sub pointScored()
    'this procedure executes if ball reaches either end of court
    tmrBall.Stop() 'stop tmrBall
    tmrPaddle.Stop() 'stop tmrPaddle
    If lblBall.Left < intPadFaceL Then 'ball has bypassed the left paddle
      scoreRight = scoreRight + 1 'add 1 to player's score
      lastPoint = 2 'player won last point
      lblRightScore.Text = scoreRight 'display new player score
    ElseIf(lblBall.Left + intBallW) > intPadFaceR Then
      'ball has bypassed the right paddle
      scoreLeft = scoreLeft + 1 'add 1 to computer's score
      lastPoint = 1 'computer won last point
      lblLeftScore.Text = scoreLeft 'display new computer score
    End If
    lblBall.Visible = False 'hide ball
    If scoreLeft = winScore Then 'computer has won game
      reset() 'call reset game variables and game display
      MsgBox("Sorry, better luck next time!") 'display consolatory message
      resetScores() 'reset scores and score display
    ElseIf scoreRight = winScore Then 'player has won game
      reset() 'call reset game variables and game display
      MsgBox("Congratulations!") 'display congratulatory message
      resetScores() 'reset scores and score display
    Else
      tmrBreak.Start() 'game still in progress, start tmrBreak
    End If
  End Sub

  Sub reset()
    'reset game variables, timers and display
    tmrBall.Stop()
    tmrBreak.Stop()
    tmrPaddle.Stop()
    lblBall.Visible = False
    lblPaddleLeft.Top = intPadLTop
    lblPaddleRight.Top = intPadRTop
    cmdPlay.Enabled = True
  End Sub

  Sub resetScores()
    'reset scores and score display
    scoreLeft = 0
    scoreRight = 0
    lblLeftScore.Text = "0"
    lblRightScore.Text = "0"
  End Sub

  Private Sub frmPong_MouseDown(sender As Object, ByVal e As _
    Windows.Forms.MouseEventArgs) _
    Handles Me.MouseDown, picPongTable.MouseDown
    'executes if mouseDown event occurs
    If e.Button = MouseButtons.Right Then 'right mouse button is down
      dnFlag = True 'set dnFlag
    ElseIf e.Button = MouseButtons.Left Then 'left mouse button is down
      upFlag = True 'set upFlag
    End If
  End Sub

  Private Sub frmPong_MouseUp(sender As Object, ByVal e As _
    Windows.Forms.MouseEventArgs) _
    Handles Me.MouseUp, picPongTable.MouseUp
    'executes if mouseUp event occurs
    If e.Button = MouseButtons.Right Then 'right mouse button has been released
      dnFlag = False 'unset dnFlag
    ElseIf e.Button = MouseButtons.Left Then 'left mouse button has been released
      upFlag = False 'unset upFlag
    End If
  End Sub

End Class