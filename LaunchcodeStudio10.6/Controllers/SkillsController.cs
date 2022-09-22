using Microsoft.AspNetCore.Mvc;

namespace LaunchcodeStudio10._6.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = @"
            <h1>Skills Tracker</h1>
            <h2>Coding skills to learn:</h2>
            <ol>
                <li>Python</li>
                <li>JavaScript</li>
                <li>C#</li>
            </ol>
            <a href='skills/form'>To form</a>
            ";
            return Content(html, "text/html");
        }

        [HttpGet("form")]
        public IActionResult Form()
        {
            string html = @"
            <form method='post' action='/skills/form'>
                <p>Date:</p>
                <input type='date' name='date'>
                <p>Python</p>
                    <select name='pythonSkills'>
                    <option value='noob'>Noob</option>
                    <option value='ameteur'>Ameteur</option>
                    <option value='intermediate'>Intermediate</option>
                    <option value='skilled'>Skilled</option>
                    <option value='professional'>Professional</option>
                    </select>
                <p>JavaScript</p>
                    <select name='jsSkills'>
                    <option value='noob'>Noob</option>
                    <option value='ameteur'>Ameteur</option>
                    <option value='intermediate'>Intermediate</option>
                    <option value='skilled'>Skilled</option>
                    <option value='professional'>Professional</option>
                    </select>
                <p>C#</p>
                    <select name='cSharpSkills'>
                    <option value='noob'>Noob</option>
                    <option value='ameteur'>Ameteur</option>
                    <option value='intermediate'>Intermediate</option>
                    <option value='skilled'>Skilled</option>
                    <option value='professional'>Professional</option>
                    </select>
                <input type='submit' value='submit'/>
            </form>
            ";
            return Content(html, "text/html");
        }

        [HttpPost("form")]
        public IActionResult FormResults(string date, string pythonSkills, string jsSkills, string cSharpSkills)
        {
            string html = $@"
            <h1>{date}</h1>
            <ol>
                <li>Python: {pythonSkills}</li>
                <li>JavaScript: {jsSkills}</li>
                <li>C#: {cSharpSkills}</li>
            </ol>
            ";
            return Content(html, "text/html");
        }
    }
}
