public class Speciality {
    private virtual ICollection<Symptom> Symptoms {get;}
    private virtual ICollection<Deployment> Supports {get;}

    public string Name;

    public Speciality () {
        Symptoms = new List<Symptom>();
        Supports = new List<Deployment>();
    }

    public Speciality (string Name) {
        this.Name = Name;
        Symptoms = new List<Symptom>();
        Supports = new List<Deployment>();
    }

    public void addSymptom(Symptom s);
    public void removeSymptom(Symptom s);

    public void addDeployment(Deployment d);
    public void removeDeployment(Deployment d);
}
