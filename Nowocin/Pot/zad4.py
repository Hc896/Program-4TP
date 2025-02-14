class Device:
    def display_message(self, message):
        print(message)

class WashingMachine(Device):
    def __init__(self):
        self.__program_number = 0

    def set_program(self, program_number):
        if 1 <= program_number <= 12:
            self.__program_number = program_number
        else:
            self.__program_number = 0
        return self.__program_number

class VacuumCleaner(Device):
    def __init__(self):
        self.__is_on = False

    def on(self):
        if not self.__is_on:
            self.__is_on = True
            self.display_message("Odkurzacz włączono")

    def off(self):
        if self.__is_on:
            self.__is_on = False
            self.display_message("Odkurzacz wyłączono")

if __name__ == "__main__":
    washing_machine = WashingMachine()
    vacuum_cleaner = VacuumCleaner()
    
    print("Numer programu pralki:", washing_machine.set_program(5))  
    
    vacuum_cleaner.on()
    vacuum_cleaner.on()
    vacuum_cleaner.on()
    vacuum_cleaner.display_message("Odkurzacz wyładował się")
    vacuum_cleaner.off()
