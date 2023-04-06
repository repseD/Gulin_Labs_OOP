#include <iostream>

class Human {
public:
    int age;
    void eat() {
        printf("eat()\n");
    }
    Human() {
        printf("Human()\n");
        age = 0;
        name = "name";
        isWorking = false;
    }
    Human(int age, std::string name, bool isWorking) {
        printf("Human(int age, std::string name, bool isWorking)\n");
        this->age = age;
        this->name = name;
        this->isWorking = isWorking;
    }
    Human(const Human& human) {
        printf("Human(const Human& human)\n");
        this->age = human.age;
        this->isWorking = human.isWorking;
        this->name = human.name;
    }
    ~Human() {
        printf("~Human()\n");
        printf("\tage = %d\n", age);
        printf("\tname = %s\n", name.c_str());
        printf("\tisWorking = %d\n", isWorking);
    }
    bool isWorking_();
private:
    std::string name;
protected:
    bool isWorking;
};

bool Human::isWorking_() {
    printf("Human::isWorking_()\n");
    return isWorking;
}

class Bob : public Human {
public:
    Bob() {
        isWorking = false; // имею доступ к этому полю
        //name = "sda" // нет доступа, из-за private
    }
};

int main() {
    {
        Human human;
        Human human1(1, "name", true);
        Human human2(human1);
        human.age = 2;
        //human.name
        //human.isWorking не могу из-за модификатора доступа private и protected
        human.isWorking_();
        human1.eat();
    }
}
