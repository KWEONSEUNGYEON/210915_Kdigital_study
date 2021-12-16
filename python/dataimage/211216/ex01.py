from sklearn.linear_model import LinearRegression

X = [[0,1],[0,2],[0,3]]
Y = [2,4,6]
lr = LinearRegression()
lr.fit(X,Y)

pre_y = lr.predict([[0,4],[0,5],[0,6]])
print('pre_y = ',pre_y)

# import cv2
#
# img = cv2.imread('bb.jpg')
# cv2.imshow('imasdf',img)
# cv2.waitKey(3*1000)
#
# expand = cv2.resize(img,None,fx=2.0,fy=2.0,interpolation=cv2.INTER_CUBIC)
# cv2.imshow('expand',expand)
# cv2.imwrite('bb_2.jpg',expand)
# cv2.waitKey(4*1000)
#
# small = cv2.resize(img,None,fx=0.5,fy=0.5,interpolation=cv2. INTER_AREA)
# cv2.imshow('samll',small)
# cv2.imwrite('bb_0.5.jpg',small)
# cv2.waitKey(5*1000)
#
# print(img.shape)
# print(expand.shape)
# print(small.shape)
#
# cv2.destroyAllWindows()