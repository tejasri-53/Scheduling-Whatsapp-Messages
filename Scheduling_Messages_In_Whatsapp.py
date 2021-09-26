import time
from selenium import webdriver
import datetime

def sendmsg(driver,name,msg):
    user = driver.find_element_by_xpath('//span[@title = "{}"]'.format(name))
    user.click()

    msg_box = driver.find_element_by_xpath('/html/body/div[1]/div[1]/div[1]/div[4]/div[1]/footer/div[1]/div/div/div[2]/div[1]/div/div[2]')
    msg_box.send_keys(msg)
    button = driver.find_element_by_xpath('/html/body/div[1]/div[1]/div[1]/div[4]/div[1]/footer/div[1]/div/div/div[2]/div[2]/button')
    button.click()


def fun(driver,names,msg,t):
    x = datetime.datetime.now()

    for i in range(len(t)):
        h,m = t[i]
        if(h==x.hour and m == x.minute and x.second == 0):
            sendmsg(driver,names[i],msg[i])

x = ["Ruchi","Deepika"]
msg = ["hello Ruchi", "hello Deepika"]
t = [(21,56),(21,56)]
driver = webdriver.Chrome()
driver.get('https://web.whatsapp.com/')
while(1):
    fun(driver,x,msg,t)
    time.sleep(1)