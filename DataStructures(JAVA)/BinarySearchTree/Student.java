package EXC2;

public class Student {
    private int studentId;
    private String name;
    private String surname;
    private double gradeAverage;

    public Student(int studentId, String name, String surname, double gradeAverage) {
        this.studentId = studentId;
        this.name = name;
        this.surname = surname;
        this.gradeAverage = gradeAverage;
    }
    
    public int getStudentId() {
        return studentId;
    }

    public void setStudentId(int studentId) {
        this.studentId = studentId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getSurname() {
        return surname;
    }

    public void setSurname(String surname) {
        this.surname = surname;
    }

    public double getGradeAverage() {
        return gradeAverage;
    }

    public void setGradeAverage(double gradeAverage) {
        this.gradeAverage = gradeAverage;
    }

    @Override
    public String toString() {
        return "Student ID: " + studentId + ", Name: " + name + ", Surname: " + surname + ", Grade Average: " + gradeAverage;
    }
}
