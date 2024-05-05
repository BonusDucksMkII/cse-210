public class Prompt{
    public List<string> _prompts;

    public string getPrompt(){
        // Get random prompt from list
        Random rndChoice = new();
        int choice = rndChoice.Next(_prompts.Count);
        return _prompts[choice];
    }

    // void _addPrompt(string NewPrompt){
    //     throw new NotImplementedException();
    // }

    // void _removePrompt(string PromptToRemove){
    //     throw new NotImplementedException();
    // }
}