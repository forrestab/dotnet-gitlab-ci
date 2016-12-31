# Building and running tests with GitLab.com CI

This is a simple dotnet core project example of how to build and run tests using the GitLab CI. The solution is from [these Microsoft docs](https://docs.microsoft.com/en-us/dotnet/articles/core/tutorials/using-with-xplat-cli#using-folders-to-organize-code). The solution is less important than the `.gitlab-ci.yml` file, which is the focus of this repository.

Couple of things to take note of:

* When figuring this out, I only used [GitLab.com](gitlab.com), so this has not been tested on a local deployment (though I don't believe there should be a problem).
* I am also checking out [GitLab.com's](gitlab.com) mirroring functionality, so the main repo is located [here](https://gitlab.com/forrestab/dotnet-gitlab-ci) (_I am leaving issues open on both repositories_).

Credit where credit is due, base yaml file started with this blog post from [dotnet thoughts](http://dotnetthoughts.net/building-dotnet-with-gitlab-ci/).
