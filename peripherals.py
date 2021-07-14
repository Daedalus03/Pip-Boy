from gpiozero import RotaryEncoder, Button
from signal import pause
import requests

modeButton = Button(12)
statButton = Button(16)
dataButton = Button(20)
radioButton = Button(21)


def communicate(path):
    def returner():
        print('http://localhost:8000/' + path)
    return returner


rotaryEncoder = RotaryEncoder(5, 6, wrap=True, max_steps=180)

rotaryEncoder.when_rotated_clockwise = communicate("rotaryRight")
rotaryEncoder.when_rotated_counter_clockwise = communicate("rotaryLeft")
modeButton.when_pressed = communicate("mode")
statButton.when_pressed = communicate("stat")
dataButton.when_pressed = communicate("data")
radioButton.when_pressed = communicate("radio")

pause()
