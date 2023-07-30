import os
from re import T
import time
from cryptography.fernet import Fernet
from tqdm import tqdm

def generate_key():
    return Fernet.generate_key()

def load_key(key_file):
    return open(key_file, "rb").read()

def save_key(key, key_file):
    with open(key_file, "wb") as key_file:
        key_file.write(key)

def encrypt_file(key, input_file, output_file):
    fernet = Fernet(key)
    with open(input_file, "rb") as file:
        original_data = file.read()
    encrypted_data = fernet.encrypt(original_data)
    with open(output_file, "wb") as encrypted_file:
        encrypted_file.write(encrypted_data)

def decrypt_file(key, input_file, output_file):
    fernet = Fernet(key)
    with open(input_file, "rb") as encrypted_file:
        encrypted_data = encrypted_file.read()
    decrypted_data = fernet.decrypt(encrypted_data)
    with open(output_file, "wb") as decrypted_file:
        decrypted_file.write(decrypted_data)

def encrypt_folder(key, folder_path):
    for root, _, files in os.walk(folder_path):
        for file in files:
            with tqdm(total=1, unit=" encryption progress", ascii=True) as progress_bar:    
                input_file_path = os.path.join(root, file)
                output_file_path = os.path.join(root, file + ".enc")
                encrypt_file(key, input_file_path, output_file_path)
                os.remove(input_file_path)
                progress_bar.update()

def decrypt_folder(key, folder_path):
    for root, _, files in os.walk(folder_path):
        for file in files:
            if file.endswith(".enc"):
                with tqdm(total=1, unit=" decryption progress", ascii=True) as progress_bar:  
                    input_file_path = os.path.join(root, file)
                    output_file_path = os.path.join(root, file[:-4])
                    decrypt_file(key, input_file_path, output_file_path)
                    os.remove(input_file_path)
                    progress_bar.update()

if __name__ == "__main__":
    # Change these paths accordingly
    key_file = "encryption.key"
    folder_to_encrypt = "./baydin"

    if not os.path.exists(key_file):
        key = generate_key()
        save_key(key, key_file)
    else:
        key = load_key(key_file)

    
    start_time = time.time()
    decrypt_folder(key, folder_to_encrypt)
    end_time = time.time()
    elapse_time = end_time - start_time
    print(elapse_time)
    
    #decrypt_folder(key, folder_to_encrypt)

    # To decrypt the folder, uncomment the following line
    # decrypt_folder(key, folder_to_encrypt)
