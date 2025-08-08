# 📱 Social Media Fullstack

A fullstack **social media** application built with **.NET 9** (Clean Architecture) for the backend and **Next.js 14** + **Tailwind CSS** for the frontend.  
The project is containerized with **Docker** and uses **PostgreSQL** as the database.

This setup is designed as a monorepo, making it easy to manage both frontend and backend in one place.

---

## 🚀 Tech Stack

**Frontend**

- [Next.js 14](https://nextjs.org/) with App Router
- [React 18](https://react.dev/)
- [Tailwind CSS](https://tailwindcss.com/)

**Backend**

- [.NET 9](https://dotnet.microsoft.com/)
- Clean Architecture principles
- REST API with Controllers
- PostgreSQL 16
- Entity Framework Core

**DevOps / Tooling**

- [Docker](https://www.docker.com/) & Docker Compose
- pnpm for package management
- Git & GitHub

---

## 📂 Project Structure

```
/
├── api/                  # Backend (.NET 9 API, Clean Architecture)
│   ├── src/API           # API layer
│   ├── src/Application   # Application layer
│   ├── src/Domain        # Domain layer
│   └── src/Infrastructure# Infrastructure layer
│
├── web/                  # Frontend (Next.js + Tailwind)
│   ├── src/app           # Next.js App Router pages
│   └── public/           # Static assets
│
├── docker-compose.yml    # Multi-service setup
├── .gitignore
├── .gitattributes
└── README.md
```

---

## 🛠️ Getting Started (Local Development)

### 1. Clone the repository

```bash
git clone https://github.com/Whisperpiano/social-media-fullstack.git
cd social-media-fullstack
```

### 2. Run the backend locally

```bash
cd api
dotnet restore
dotnet run
```

The backend will be available at:

```
http://localhost:5000
```

### 3. Run the frontend locally

```bash
cd web
pnpm install
pnpm dev
```

The frontend will be available at:

```
http://localhost:3000
```

---

## 🐳 Running with Docker

Make sure Docker and Docker Compose are installed.

### 1. Build and start the services

```bash
docker compose --profile api --profile db --profile web up --build
```

### 2. Access the services

- **API** → [http://localhost:5000](http://localhost:5000)
- **Frontend** → [http://localhost:3000](http://localhost:3000)
- **PostgreSQL** runs on port `5432`

---

## 📌 Environment Variables

Create `.env.local` in the `web` folder for the frontend:

```env
NEXT_PUBLIC_API_URL=http://localhost:5000
```

For the backend, set environment variables in `appsettings.Development.json` or through Docker Compose.

---

## 📅 Roadmap

- [ ] Authentication & Authorization (JWT)
- [ ] User profiles
- [ ] Posts with images
- [ ] Likes & comments
- [ ] Real-time notifications
- [ ] Deployment to production

---

## 📜 License

This project is licensed under the MIT License.

---
