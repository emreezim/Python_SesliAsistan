import cv2

def yuztanima():
    vid=cv2.VideoCapture(0)
    yuz_cascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalface_default.xml')
    img = cv2.imread(r"Emre.jpg")
    x=0
    y=0
    w=0
    h=0

    while(True):
        ret,frame=vid.read()
        gray=cv2.cvtColor(frame,cv2.COLOR_BGR2GRAY)
        gray2 = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
        yuzler2 = yuz_cascade.detectMultiScale(gray2, 1.3, 5)
        yuzler= yuz_cascade.detectMultiScale(gray,1.3, 5)

        print(yuzler)
    # x   y   w   h
    #225  67 196 196
    #187 142 212 212

        for (x, y, w, h) in yuzler:
            cv2.rectangle(frame, (x, y), (x + w, y + h), (85, 255, 0), 3)


        if x == 200 in yuzler:
            print("sadsad")
            break


        cv2.imshow('title', frame)



        if cv2.waitKey(1) & 0xFF == ord('q'):
           break
    vid.release()
    cv2.destroyAllWindows()