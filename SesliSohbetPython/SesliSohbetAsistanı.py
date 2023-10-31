import random
import time
import fnmatch
import cv2
from playsound import playsound
import speech_recognition as sr
from gtts import gTTS
import pyaudio
import os
from selenium import webdriver
from selenium.webdriver.common.by import By
import requests
from bs4 import BeautifulSoup
from selenium.webdriver.chrome.service import Service as ChromeService
from selenium.webdriver.support.wait import WebDriverWait
from webdriver_manager.chrome import ChromeDriverManager
import googletrans
from googletrans import Translator
import ArdunioProje
import tkinter as tk
from tkinter import filedialog
from selenium.webdriver.common.keys import Keys
import googlemaps
import requests
import cv2
import dlib
import face_recognition
import pywhatkit as kit
import phonenumbers
from phonenumbers import carrier, timezone, geocoder
import tempfile
import win32api
import win32print
import sqlite3


r=sr.Recognizer()
connect = sqlite3.connect("EngWord.db")
imlec = connect.cursor()
class sesliasistan():
   
    def seslendirme(self,metin):
        xtts=gTTS(text=metin,lang="tr")
        dosya="dosya"+str(random.randint(0,121231231))+".mp3"
        xtts.save(dosya)
        playsound(dosya)
        os.remove(dosya)
    
       
    def ses_kayit(self):
        with sr.Microphone() as kaynak:
            print("Sizi dinliyoruz...")
            listen=r.listen(kaynak)
            voice=" "
            
            try:
                voice=r.recognize_google(listen,language="tr-TR")
            except sr.UnknownValueError:
                self.seslendirme("Sesinizi Anlayamadım,Lütfen tekrar söyleyiniz")
            return voice 



    def faceDef(self):



        detector = dlib.get_frontal_face_detector()
        emre = face_recognition.load_image_file("emre.jpg")
        emre_enc = face_recognition.face_encodings(emre)[0]
        tulay = face_recognition.load_image_file("tulay.jpg")
        tulay_enc = face_recognition.face_encodings(tulay)[0]

        cap = cv2.VideoCapture(0)

        while True:
            ret, frame = cap.read()

            face_loc = []
            faces = detector(frame)
            for face in faces:
                x = face.left()
                y = face.top()
                w = face.right()
                h = face.bottom()
                face_loc.append((y, w, h, x))

            # face_loc=face_recognition.face_locations(frame)
            face_encoding = face_recognition.face_encodings(frame, face_loc)
            i = 0

            for face in face_encoding:

                y, w, h, x = face_loc[i]
                sonuc = face_recognition.compare_faces([emre_enc], face)
                sonuc1 = face_recognition.compare_faces([tulay_enc], face)
                if sonuc[0] == True:
                    cv2.rectangle(frame, (x, y), (w, h), (255, 0, 0), 2)
                    cv2.putText(frame, "Emre", (x, h + 35), cv2.FONT_HERSHEY_PLAIN, 2, (0, 0, 255), 2)
                elif sonuc1[0] == True:
                    cv2.rectangle(frame, (x, y), (w, h), (255, 0, 0), 2)
                    cv2.putText(frame, "Tulay", (x, h + 35), cv2.FONT_HERSHEY_PLAIN, 2, (0, 0, 255), 2)
                else:
                    cv2.rectangle(frame, (x, y), (w, h), (255, 0, 0), 2)
                    cv2.putText(frame, "yabanci", (x, h + 35), cv2.FONT_HERSHEY_PLAIN, 2, (0, 0, 255), 2)
            cv2.imshow("1", frame)
            if cv2.waitKey(10) & 0xFF == ord("q"):
                break
        cap.release()
        cv2.destroyAllWindows()

    def ses_karisilik(self,gelen_ses):
        if "selam" in gelen_ses:
           self.seslendirme("Size de selamlar")
        elif "merhaba" in gelen_ses:
           self.seslendirme("Size de merhabalar")
        elif "nasılsın" in gelen_ses:
            self.seslendirme("iyiyim siz nasılsınız")
        elif "nasıl gidiyor" in gelen_ses:
            self.seslendirme("iyi sizin?")
        elif "yüz tanıma" in gelen_ses:
            print("asdsadsa")
            self.faceDef()
        elif gelen_ses.find("video") > -1:
            veri=gelen_ses.split(" ")
            self.seslendirme("{} videosu Açılıyor".format(veri[0]))
            time.sleep(1)
            url="https://youtube.com/search?q={}".format(veri[0])
            tarayici=webdriver.Chrome(service=ChromeService(ChromeDriverManager().install()))
            tarayici.get(url)
            tarayici.find_element(By.XPATH, "//*[@id='video-title']/yt-formatted-string").click()

            time.sleep(100)     
        elif gelen_ses.find("arama")>-1 or gelen_ses.find("Arama") > -1:

            try:
                #self.seslendirme("Ne aramamı istersiniz")
                veri = gelen_ses.split(" ")
                print("{} için bulduklarım bunlar".format(veri[0]))
                self.seslendirme("{} için bulduklarım bunlar".format(veri[0]))

                url = "https://www.google.com/search?q={}".format(veri[0])

                tarayici = webdriver.Chrome(service=ChromeService(ChromeDriverManager().install()))
                tarayici.get(url)
                buton=tarayici.find_element(By.XPATH,"//*[@id='rso']/div[1]/div/div/div/div/div/div/div/div[1]/div/span/a/h3")
                buton.click()
                time.sleep(300)
            except:
                self.seslendirme("Hata Oluştu")

        elif gelen_ses.find("film")>-1:
            #try:
                    self.seslendirme("Hangi filmi açmamı istersiniz")
                    veri=self.ses_kayit()
                    self.seslendirme("{} filmini açıyorum....".format(veri))

                    url="https://www.google.com/search?q={}+izle".format(veri)

                    tarayici=webdriver.Chrome(service=ChromeService(ChromeDriverManager().install()))
                    tarayici.get(url)


                    buton=tarayici.find_element(By.XPATH,"//*[@id='kp-wp-tab-TvmWatch']/div[2]/div/div/div/div/div[2]/div/div[1]/div/div/span/a/h3")
                    buton.click()

            #//*[@id="kp-wp-tab-overview"]/div[2]/div/div/div/div/div/div[1]/div/div/span/a/h3

                    time.sleep(3)

             


            #except:
                    #self.seslendirme("internetten kaynaklı bir hata meydana geldi.lütfen internetinizi kontrol ediniz")
                    #a=  "//*[@id='kp-wp-tab-TvmWatch']/div[2]/div/div/div/div/div[1]/div/div[1]/div/a/h3"
        elif gelen_ses.find("film önerisi")>-1:
                try:
                    self.seslendirme("hangi tür film istersinz")
                    veri=self.ses_kayit()
                    self.seslendirme("{} türü için bulduğum filmler şunlar...".format(veri))
                    url="https://www.filmmodu13.com/kategori/{}".format(veri)
                    tarayici=webdriver.Chrome(service=ChromeService(ChromeDriverManager().install()))
                    tarayici.get(url)
                    self.seslendirme("Eğer kararsızsanız size film önerisinde bulunmak istiyorum")
                    cevap=self.ses_kayit()
                    print(cevap)
                    time.sleep(2)

                    if cevap=="Evet":
                        self.seslendirme("Filminizi hemen getiriyorum....")
                        rastgele_sayi=random.randint(1,24)
                        buton=tarayici.find_element(By.XPATH,"/html/body/main/div[2]/div[{}]/div/a".format(rastgele_sayi)).click()

                       
                     

                        self.seslendirme("Keyifli seyirler...")
                    else:
                        self.seslendirme("Keyifli seyirler...")

                except:
                    self.seslendirme("internetten kaynaklı bir hata meydana geldi.lütfen internetinizi kontrol ediniz")
        
        
        elif  gelen_ses.find("hava durumu")>-1:
            
           try: 
                #self.seslendirme("hangi şehrin hava durumunu istersiniz")
                cevap=gelen_ses.split(" ")

            

                url="https://www.ntv.com.tr/{}-hava-durumu".format(cevap[0])
                request=requests.get(url)

                htlm_icerigi=request.content
                soup=BeautifulSoup(htlm_icerigi,"html.parser")

                gunduz_sicaklikları=soup.find_all("p",{"class":"hava-durumu--detail-data-item-bottom-temp-max"})
                gece_sicakliklari=soup.find_all("p",{"class":"hava-durumu--detail-data-item-bottom-temp-min"})
                hava_durumu=soup.find_all("div",{"class":"container hava-durumu--detail-data-item-bottom-desc"})
                gun_isimleri = soup.find_all("div", {"class": "daily-report-tab-content-pane-item-date"})

                gunduz=[]
                gece=[]
                hava=[] 
                for x in gunduz_sicaklikları:
                    x=x.text
                    gunduz.append(x)
        

                for y in gece_sicakliklari:
                    y=y.text
                    gece.append(y)

                for z in hava_durumu:
                    z=z.text
                    hava.append(z)
                
                birlestirme="{} için yarinki hava raporları şöyle {} gündüz sıcaklığı {} gece sıcaklığı {}".format(cevap[0],hava[0],gunduz[0],gece[0])

                self.seslendirme(birlestirme)

           except:
               self.seslendirme("İstediğiniz Şehre göre hava durumu yok yada İnternetinizde sorun olabilir.İnternetinizi kontrol ediniz")

        elif gelen_ses.find("hesap yapmak") >-1:
            try:

                self.seslendirme("Hesap Makinesi Açılıyor")
                os.system(r"C:\Users\emre2\OneDrive\Desktop\Python_SesliAsistan-main\HesapMakinesi\HesapMakinesi\bin\Debug\HesapMakinesi.exe")
            except:
                self.seslendirme("Hata Oluştu,Tekrar Deneyiniz")

        elif "hesap makinesini kapat" in gelen_ses:
            try:
                os.close()

            except:
                self.seslendirme("Hata Oluştu,Tekrar Deneyiniz")
        elif gelen_ses.find("çevir")>-1:
                 cevap=gelen_ses.split(" ")
                 #self.seslendirme("Hangi dilde Çeviri yapmak istiyorsunuz")
                 #translanguage=self.ses_kayit()

                 if cevap[2].find("Türkçe")>-1:
                    result=translate(cevap[0],Turkish=True)
                    self.seslendirme("{} kelimesinin çevirisi:{}".format(cevap[0], result))
                    print("{} kelimesinin çevirisi:{}".format(cevap[0], result))
                 if cevap[2].find("Almanca")>-1:
                    result = translate(cevap[0], Germany=True)
                    self.seslendirme("{} kelimesinin çevirisi:{}".format(cevap[0], result))
                    print("{} kelimesinin çevirisi:{}".format(cevap[0], result))
                 if cevap[2].find("İngilizce")>-1:
                    result = translate(cevap[0],English=True)
                    self.seslendirme("{} kelimesinin çevirisi:{}".format(cevap[0], result))
                    print("{} kelimesinin çevirisi:{}".format(cevap[0], result))

        elif gelen_ses.find("yazdırma")>-1 or gelen_ses.find("Yazdırma") > -1:
            try:
                self.seslendirme("Yazdırma işlemi yapıcağınız dosyayı söyleyiniz.")
                filename=self.ses_kayit()
                print(filename)
                filepath=r"C:\Users\emre2\OneDrive\Desktop\Resimler"

                with os.scandir(filepath) as tarama:
                     for belge in tarama:
                         if fnmatch.fnmatch(belge.name,"{}*".format(filename)):

                             if fnmatch.fnmatch(belge.name, "*.jpg"):
                                 os.startfile(r"C:\Users\emre2\OneDrive\Desktop\Python_SesliAsistan-main\Resimler\{}.jpg".format(filename), "printto")
                             elif fnmatch.fnmatch(belge.name,"*.pdf"):
                                 os.startfile(r"C:\Users\emre2\OneDrive\Desktop\Python_SesliAsistan-main\Resimler\{}.pdf".format(filename), "printto")

                         self.seslendirme("Yazdırma İşlemi Gerçekleştiriliyor")
            except:
                self.seslendirme("Bir HATA Oluştu Lütfen tekrar deneyiniz")



        elif gelen_ses.find("mesaj") >-1 :

            """
            print(datetime.now().hour)
            print(datetime.now().minute)
            kit.sendwhatmsg_to_group(name,message,datetime.now().hour,datetime.now().minute+1)
            """

            self.seslendirme("Mesaj Göndereceğiniz Kişiyi Söyleyiniz")
            name=self.ses_kayit()
            name=name.title()
            print(name)
            self.seslendirme("Göndereceğiniz mesajı söyleyiniz")
            message=self.ses_kayit()
            message=message.title()
            driver=webdriver.Chrome(service=ChromeService(ChromeDriverManager().install()))
            driver.get("https://web.whatsapp.com/")
            driver.maximize_window()
            print('Karekodu okutunuz')
            input("Ekran geldiyse enter'a basınız")
            kisibul=driver.find_element(By.XPATH,"//span[@title='{}']".format(name))
            kisibul.click()
            messageplace=driver.find_element(By.XPATH,'//*[@id="main"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p')
            messageplace.send_keys(message + Keys.ENTER)


            self.seslendirme("Mesajınız Gönderildi")

        elif gelen_ses.find("kaydet")>-1 or gelen_ses.find("Kaydet")>-1:

            imlec.execute("CREATE TABLE IF NOT EXISTS WordInf (WordId INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,engMean TEXT NOT NULL,turkishMean TEXT NOT NULL)")
            self.seslendirme("Kelimenin İngilizcesini Söyleyiniz")
            engMean=self.ses_kayit()
            print(engMean)
            self.seslendirme("Kelimenin Türkçesini Söyleyiniz")
            turkishMean=self.ses_kayit()
            print(turkishMean)

            imlec.execute("Insert Into WordInf (engMean,turkishMean) values ('{}','{}')".format(engMean,turkishMean))
            connect.commit()
            self.seslendirme("Kaydedildi")


        elif gelen_ses.find("yarışma"):
            imlec.execute("Select MAX(WordId) from WordInf")
            result=imlec.fetchall()

            for b in result:
                maxsayi=b[0]

            for i in range(1,maxsayi+1):
                komut = "SELECT engMean,turkishMean FROM WordInf where WordId = {}".format(i)
                imlec.execute(komut)
                veri = imlec.fetchone()
                self.seslendirme("{} kelimesini türkçesi nedir?".format(veri[0]))
                cevap = self.ses_kayit()
                if cevap == veri[1]:
                    self.seslendirme("Doğru")
                else:
                    self.seslendirme("Yanlış")
                    break






























"""
        elif (gelen_ses in "led'i yak"):
            
                self.seslendirme("led'inizi hemen yakıyorum")
                ArdunioProje.led_islemleri(1)
            
               

        elif (gelen_ses in "led'i söndür"):
           try: 
                self.seslendirme("led'inizi hemen söndürüyorum")     
                ArdunioProje.led_islemleri(0)
           except:
                self.seslendirme("Bir hata meydana geldi")    
"""







asistan=sesliasistan()

def uyanma_fonksiyonu(metin):
    if(metin=="hey siri" or metin=="hey google"):
        asistan.seslendirme("dinliyorum...")
        cevap=asistan.ses_kayit()
        if(cevap != ""):
            asistan.ses_karisilik(cevap)




def translate(text, English =False,Germany=False,Turkish=False):
    translation_dict={}
    translator=Translator()
    if Germany==True:
        result=translator.translate(text,dest='de')
        translation_dict["Almanca"]= result.text
    if English==True:
        result=translator.translate(text,dest='en')
        translation_dict["İngilizce"]= result.text
    if Turkish==True:
        result=translator.translate(text,dest='tr')
        translation_dict["Türkçe"]= result.text
    return  translation_dict
while True:
    ses=asistan.ses_kayit()

    if(ses != " "):
        ses=ses.lower()
        print(ses)
        uyanma_fonksiyonu(ses)
        

   