var websters = new Dictionary<string, string> { { "Cromulent", "I never heard the word before moving to Springfield." } };
websters.ShouldContainKeyAndValue("Cromulent", "Fine, acceptable.");