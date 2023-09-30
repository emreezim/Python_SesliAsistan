import random
import time


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
from datetime import datetime
import ArdunioProje
import tkinter as tk
from tkinter import filedialog
from selenium.webdriver.common.keys import Keys
import googlemaps
import requests
import pywhatkit as kit
import phonenumbers
from phonenumbers import carrier, timezone, geocoder
import tempfile
import win32api
import win32print

r=sr.Recognizer()

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





    def ses_karisilik(self,gelen_ses):
        if "selam" in gelen_ses:
           self.seslendirme("Size de selamlar")
        elif "merhaba" in gelen_ses:
           self.seslendirme("Size de merhabalar")
        elif "nasılsın" in gelen_ses:
            self.seslendirme("iyiyim siz nasılsınız")
        elif "nasıl gidiyor" in gelen_ses:
            self.seslendirme("iyi sizin?")    
        elif "video aç" in gelen_ses:
            self.seslendirme("Ne açmamı istersiniz")
            veri=self.ses_kayit()
            self.seslendirme("{} Açılıyor".format(veri))
            time.sleep(1)
            url="https://youtube.com/search?q={}".format(veri)
            tarayici=webdriver.Chrome(service=ChromeService(ChromeDriverManager().install()))
            tarayici.get(url)
            tarayici.find_element(By.XPATH, "//*[@id='video-title']/yt-formatted-string").click()

            time.sleep(100)     
        elif "google aç" in gelen_ses or "arama yap" in gelen_ses:
                self.seslendirme("Ne aramamı istersiniz")
                veri = self.ses_kayit()
                print("{} için bulduklarım bunlar".format(veri))
                self.seslendirme("{} için bulduklarım bunlar".format(veri))

                url = "https://www.google.com/search?q={}".format(veri)

                tarayici = webdriver.Chrome(service=ChromeService(ChromeDriverManager().install()))
                tarayici.get(url)
                tarayici.find_element(By.CSS_SELECTOR,"#rso > div:nth-child(1) > div > div > div > div > div > div > div > div.yuRUbf > div > span > a > h3").click()
                time.sleep(300)
                #self.seslendirme("Hata Oluştu")

        elif "filmi aç" in gelen_ses:
            #try:
                    self.seslendirme("Hangi filmi açmamı istersiniz")
                    veri=self.ses_kayit()
                    self.seslendirme("{} filmini açıyorum....".format(veri))

                    url="https://www.google.com/search?q={}+izle".format(veri)

                    tarayici=webdriver.Chrome(service=ChromeService(ChromeDriverManager().install()))
                    tarayici.get(url)

                    tarayici.implicitly_wait(5)
                    buton=tarayici.find_element(By.XPATH,"//*[@id='kp-wp-tab-overview']/div[2]/div/div/div/div/div/div[1]/div/div/span/a/h3").click()

            #//*[@id="kp-wp-tab-overview"]/div[2]/div/div/div/div/div/div[1]/div/div/span/a/h3

                    time.sleep(3)
      
             


            #except:
                #self.seslendirme("internetten kaynaklı bir hata meydana geldi.lütfen internetinizi kontrol ediniz")
                    #a=  "//*[@id='kp-wp-tab-TvmWatch']/div[2]/div/div/div/div/div[1]/div/div[1]/div/a/h3"
        elif "film önerisi yap" in gelen_ses:
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
        
        
        elif "hava durumu tahmini" in gelen_ses or "hava durumu" in gelen_ses:
            
           try: 
                self.seslendirme("hangi şehrin hava durumunu istersiniz")
                cevap=self.ses_kayit()

            

                url="https://www.ntv.com.tr/{}-hava-durumu".format(cevap)
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
                
                birlestirme="{} için yarinki hava raporları şöyle {} gündüz sıcaklığı {} gece sıcaklığı {}".format(cevap,hava[0],gunduz[0],gece[0])

                self.seslendirme(birlestirme)

           except:
               self.seslendirme("İstediğiniz Şehre göre hava durumu yok yada İnternetinizde sorun olabilir.İnternetinizi kontrol ediniz")

        elif "Hesap Makinesi Aç" in gelen_ses or "hesap makinesi" in gelen_ses:
            try:

                self.seslendirme("Hesap Makinesi Açılıyor")
                os.system(r"D:\ProjeYedeği\HesapMakinesi\HesapMakinesi\HesapMakinesi\HesapMakinesi\HesapMakinesi\bin\Debug\HesapMakinesi.exe")


            except:
                self.seslendirme("Hata Oluştu,Tekrar Deneyiniz")

        elif "hesap makinesini kapat" in gelen_ses:
            try:
                os.close()

            except:
                self.seslendirme("Hata Oluştu,Tekrar Deneyiniz")
        elif "çeviri Yap" in gelen_ses or "çeviri" in gelen_ses:

                 self.seslendirme("Çeviri Yapacağınız Kelimeyi Söyleyiniz")
                 cevap=self.ses_kayit()
                 print(cevap)
                 self.seslendirme("Hangi dilde Çeviri yapmak istiyorsunuz")
                 translanguage=self.ses_kayit()

                 if translanguage=="Türkçe":
                    result=translate(cevap,Turkish=True)
                    self.seslendirme("{} kelimesinin çevirisi:{}".format(cevap, result))
                    print("{} kelimesinin çevirisi:{}".format(cevap, result))
                 if translanguage=="Almanca":
                    result = translate(cevap, Germany=True)
                    self.seslendirme("{} kelimesinin çevirisi:{}".format(cevap, result))
                    print("{} kelimesinin çevirisi:{}".format(cevap, result))
                 if translanguage=="İngilizce":
                    result = translate(cevap,English=True)
                    self.seslendirme("{} kelimesinin çevirisi:{}".format(cevap, result))
                    print("{} kelimesinin çevirisi:{}".format(cevap, result))

        elif "yaz" in gelen_ses or "yazdırma" in gelen_ses:

            self.seslendirme("Yazdırma işlemi yapıcağınız dosyayı seçiniz.")
            dosyasec()
            self.seslendirme("Yazdırma İşlemi Gerçekleştiriliyor")
        """elif "harita" in gelen_ses:
            self.seslendirme("Mesaj Göndereceğiniz Kişiyi Söyleyiniz")
            name=self.ses_kayit()
            name=name.title()
            print(name)
            self.seslendirme("Göndereceğiniz mesajı söyleyiniz")
            message=self.ses_kayit()
            driver=webdriver.Chrome(service=ChromeService(ChromeDriverManager().install()))
            driver.maximize_window()

            kisibul=driver.find_element(By.XPATH,"//span[@title='{}'']".format(name))
            messageplace=driver.find_element(By.XPATH,'//*[@id="main"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p')
            messageplace.send_keys(message + Keys.ENTER)

            self.seslendirme("Mesajınız Gönderildi")
            """

            

















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

def dosyasec():
    filename = tk.filedialog.askopenfilename()
#C:\\Users\\emre2\\OneDrive\\Desktop\\katalog.pdf

    os.startfile(filename, "printto")
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
        

   