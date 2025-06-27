import ctypes
import time
user32 = ctypes.WinDLL('user32', use_last_error= True)
def move_mouse_windows(30, 40):
    user32.SetCursorPosition(30, 40)
