using System;


public class Resume
{
    public string _name = "";

    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine(this._name);
        
        // for(int i = 0; i<this._jobs.Count; i++)
        // {
        //     Console.WriteLine($"{this._jobs[i]._jobTitle} ({this._jobs[i]._company}) {this._jobs[i]._startYear}-{this._jobs[i]._endYear}");
        // }

         foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}