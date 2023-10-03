using SimpleCompositeCSharp;

GitComponent pullRequest = new PullRequest("my-feature-branch", "main");
pullRequest.Add(new Commit("82a79d4"));
pullRequest.Add(new Commit("1c053ff"));
pullRequest.Add(new Commit("1b5f943"));
pullRequest.Add(new Commit("b1f9423"));

pullRequest.ShowDetail();