def other_symbols(your_password):
    count_numbers = len([x for x in your_password if x.isdigit()])
    count_upper = len([x for x in your_password if x.isupper()])
    count_lower = len([x for x in your_password if x.islower()])
    new_len = count_numbers + count_upper + count_lower
    return new_len
 
def validator(your_password):
    your_password = str(your_password)
    if len(your_password) < 8:
        return "Длина вашего пароля должна составлять не менее 8 символов."
    if not [x for x in your_password if x.isdigit()]:
        return "Ваш пароль должен содержать цифры."
    if not [x for x in your_password if x.isupper()]:
        return "Ваш пароль должен содержать заглавные буквы."
    if not [x for x in your_password if x.islower()]:
        return "Ваш пароль должен содержать строчные буквы."
    if other_symbols(your_password) == len(your_password):
        return "Ваш пароль должен содержать другие символы."
    return your_password

def test():
    a = validator("Sword")
    b = validator(12345678)
    c = validator("Eskaliburus")
    d = validator("123DKLSDFGS")
    e = validator("123Eskaliburus")
    f = validator("123@Eskaliburus")
 
    print("Test word - Sword. Out - ", a)
    print("Test word - 12345678. Out -", b)
    print("Test word - Eskaliburus. Out -", c)
    print("Test word - 123DKLSDFGS. Out -", d)
    print("Test word - 123Eskaliburus. Out -", e)
    print("Test word - 123@Eskaliburus. Out -", f)
 
if __name__ == "__main__":
    test()