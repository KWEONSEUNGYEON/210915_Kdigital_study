import cv2

# b g r 순서

img = cv2.imread('aa.jpg', cv2.IMREAD_COLOR)

print(img.shape)
print(img[100,100])

cv2.imshow('창의제목', img)
retvalue = cv2.waitKey(0)
print(retvalue)
if retvalue == 49 :
    print('1을 입력했네요')
if retvalue == 50:
    print('2를 입력했네요')
cv2.imwrite('aa_copy.jpg', img)