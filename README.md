# 🪐 Planet AR : Exploration Immersive du Système Solaire

## 🎯 Objectif Pédagogique
Cette application de **Réalité Augmentée (RA)** propose une expérience immersive pour découvrir les corps célestes de notre système solaire. Elle permet aux utilisateurs de visualiser la Terre et d'autres planètes en 3D, tout en fournissant des données géographiques précises sur les océans majeurs de notre planète.

---

## 🚀 Fonctionnalités du Projet

### 1. Immersion RA avec Vuforia
* **Détection Intelligente** : Utilisation d'images cibles pour ancrer les modèles 3D dans l'environnement réel de l'utilisateur.
* **Stabilité Accrue** : L'affichage est propulsé par le moteur **Vuforia Engine**, garantissant une superposition fluide des objets virtuels.

### 2. Exploration Interactive des Océans
L'application intègre un système d'information dynamique sur les 5 océans de la Terre :
* **Océan Pacifique** : Le plus grand et le plus profond, couvrant plus d'un tiers de la surface terrestre.
* **Océan Atlantique** : Sépare l'Europe et l'Afrique du continent américain.
* **Océan Indien** : Réputé pour ses eaux chaudes et ses systèmes de moussons.
* **Océan Austral** : Entoure l'Antarctique avec des courants froids et puissants.
* **Océan Arctique** : Le plus petit et le plus froid, majoritairement recouvert de glace.

### 3. Contrôle de l'Animation et UI
* **Rotation 360°** : Les planètes tournent de manière fluide pour une observation complète.
* **Système de Toggle** : Un bouton UI permet de stopper ou de relancer la rotation à tout moment.
* **Interface Intuitive** : Panneau d'information rétractable et navigation via des boutons "Précédent" / "Suivant".

---

## 🛠️ Détails Techniques (Scripts C#)

### ✨ `OceanPanelController.cs`
C'est le cœur logique de l'interface utilisateur :
* **Gestion des Données** : Stockage des connaissances via les tableaux `oceanNames` et `oceanDescriptions`.
* **Navigation** : Méthodes `NextOcean()` et `PreviousOcean()` pour boucler à travers les informations.
* **Affichage Dynamique** : Mise à jour en temps réel des composants **TextMeshPro**.

### 🔄 `animationClick.cs`
Gère l'interactivité des objets 3D :
* **Rotation auto-adaptative** : Utilise `transform.Rotate` sur l'axe vertical (`Vector3.up`).
* **Vitesse Configurable** : La variable `rotationSpeed` est ajustable directement depuis l'inspecteur Unity.

---

## 📂 Structure des Assets
Le projet utilise des modèles 3D de haute qualité avec des matériaux **URP (Universal Render Pipeline)** :
* **Planètes** : Earth, Mars, Jupiter, Mercury, Venus, Saturn, Uranus, Neptune, Pluto.
* **Corps Célestes** : Moon, Sun Sphere, Asteroids Belt, Nebula.
* **Organisation** : Dossiers structurés pour les `Scenes`, `Scripts`, `StreamingAssets` (Vuforia) et `TextMesh Pro`.

---

## 🎥 Vidéo démonstrative


https://github.com/user-attachments/assets/c307f9d3-4b1c-4dd7-b898-84208dea082e



---

## 👤 Réalisé par
* **Anas KHAIY**
* **El mahdi BEN MEKKI**
* **Mohamed BOUIZERGUANE**

---

## 🎓 Encadré par
* **Pr. RHAZI Ahmed-Reda**
