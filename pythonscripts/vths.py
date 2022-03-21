import speech_recognition as sr

filename = "C:/Users/D3zhu/Desktop/RecoSign/audio/record.wav"

r = sr.Recognizer()

with sr.AudioFile(filename) as source:
    # listen for the data (load audio to memory)
    audio_data = r.record(source)
    # recognize (convert from speech to text)
    text = r.recognize_google(audio_data)
    print(text)