[1]: http://topshelf-project.com
[2]: http://research.microsoft.com/en-us/projects/orleans/
Topshelf.Orleans
================

Topshelf.Orleans is a project extending the [Topshelf Project][1] to host [Microsoft Research's Project "Orleans"][2].

```c#
HostFactory.Run(c => {
    c.Service<OrleansService>(s => {
        s.ConstructUsing(sc => {
            sc.Name(Dns.GetHostName());
            sc.ConfigFileName("");
        });

        s.WhenStarted((service, control) => service.Start());
        s.WhenStopped((service, control) => service.Stop());
    });
    c.RunAsPrompt();
});