# Tarea Academica Semana 4: Gestor de Álbumes y Canciones
Este programa permite gestionar álbumes musicales y sus canciones, cumpliendo con los siguientes requerimientos.

---

## Entidades

### Canción
La entidad **Canción** debe tener al menos las siguientes propiedades:
- **Código de la canción**
- **Nombre de la canción**
- **Duración** (en minutos o segundos)

### Álbum
La entidad **Álbum** debe tener al menos las siguientes propiedades:
- **Código del álbum**
- **Nombre del álbum**

⚠️ Un álbum puede contener **muchas canciones**, pero **no se deben permitir canciones repetidas** dentro del mismo álbum.

---

## Requerimientos de la aplicación
- [x] Registrar múltiples álbumes (no se debe permitir el registro de dos álbumes con el mismo código).
- [x] Mostrar todos los álbumes registrados.
- [x] Registrar múltiples canciones en sus respectivos álbumes seleccionados.
- [x] Mostrar el nombre de todas las canciones registradas.
- [ ] Listar el nombre de las canciones registradas en un álbum seleccionado.
- [ ] Obtener el álbum con mayor número de canciones registradas.
- [ ] Listar los álbumes donde se encuentra registrada una canción seleccionada.
- [ ] Obtener el nombre de la canción con **mayor** y **menor** duración registrada.

---

## Restricciones técnicas

- Utilizar el manejo de **Listas** (no arreglos ni otras estructuras).
- Utilizar el manejo de **ListBox** para mostrar datos en formato de lista.
- Utilizar el manejo de **MessageBox** para mostrar resultados al usuario.

---

## 📚 Referencia

Este proyecto se basa en el laboratorio:  
[**Lab06 - Multilistas en Windows Forms (.Net Framework) I**](https://www.youtube.com/watch?v=-1Bvo03GZ_0&t=367s)
