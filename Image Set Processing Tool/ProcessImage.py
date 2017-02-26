import sys
import cv2
import numpy as np

argList = sys.argv
img1 = cv2.imread(argList[1])

i = 2

def performAction(action):
    global i
    global img1
    if action == "brightness":                  #Next arg will be for brightness amount
        img1 = cv2.addWeighted(img1, 1, np.zeros(img1.shape, img1.dtype), 0, float(argList[i+1]))
    if action == "contrast":
        img1 = cv2.addWeighted(img1, float(argList[i+1]),np.zeros(img1.shape,img1.dtype), 0, 0)
    if action == "blackandwhite":
        img1 = cv2.cvtColor(img1, cv2.COLOR_BGR2GRAY)
    if action == "laplace":
        img1 = cv2.Laplacian(img1, cv2.CV_64F)


while (i < len(argList)):
    performAction(argList[i])
    i += 1

cv2.imwrite(argList[2], img1)