# SoulsseekerWorkshopApp

A minimal .NET 9 WebAPI template for the Soulsseeker GitOps workshop.

> **Two repos are involved:**
> - **This repo** (your fork) — where you write code and push changes. You own this, no PRs needed.
> - **The infra repo** (`SoulsseekerInfra`) — the shared cluster config. You submit exactly **one PR** here to register yourself.

## Workshop steps

1. **Fork** this repository on GitHub — this is your personal copy, you push directly to it
2. **Add secrets** to your fork: Settings → Secrets and variables → Actions → add `ACR_USERNAME` and `ACR_PASSWORD` (ask the workshop host for the credentials)
3. **Edit** `src/WorkshopApp/Program.cs` — add your own endpoints
4. **Push** to your fork — GitHub Actions will automatically build and push the image, and update `helm/values.yaml` with the new version
5. **Submit one PR** to the infra repo (`SoulsseekerInfra`) adding `workshop/participants/<yourname>.yaml`:
   ```yaml
   name: <yourname>
   repoURL: https://github.com/<yourgithubusername>/KubernernetesWorkshop
   ```
   > `name` becomes your subdomain — keep it short and lowercase. This is the only PR you submit to the infra repo.
6. Once the workshop host merges your PR, watch ArgoCD deploy your app to `https://<yourname>.kubernetes.soulsseeker.com` 🚀

## Local development

```sh
cd src/WorkshopApp
dotnet run
# visit http://localhost:5000
```
