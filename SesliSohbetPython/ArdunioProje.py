"""from pyfirmata import Arduino
import inspect



def led_islemleri(deger):
        
            board=Arduino("COM6")
           
            board.get_pin("d:7:o")
            if(deger==1):
                board.digital[7].write(0)
                board.exit()
            elif(deger==0):
                board.digital[7].write(0)
                board.exit()
"""