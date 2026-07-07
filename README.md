# SoulsseekerWorkshopApp

A minimal .NET 9 WebAPI template for the Soulsseeker GitOps workshop.

## Workshop steps

1. **Fork** this repository on GitHub
2. **Edit** `src/WorkshopApp/Program.cs` — add your own endpoints
3. **Push** your changes — GitHub Actions will build and push the image automatically
4. **Copy the image tag** printed at the end of the Actions run
5. **Edit** `helm/values.yaml` and set `image.tag` to that value
6. **Commit & push** `helm/values.yaml`
7. **Submit a PR** to the infra repo adding `workshop/participants/<yourname>.yaml`
8. Watch ArgoCD deploy your app to `https://<yourname>.kubernetes.soulsseeker.com` 🚀

## Local development

```sh
cd src/WorkshopApp
dotnet run
# visit http://localhost:5000
```
