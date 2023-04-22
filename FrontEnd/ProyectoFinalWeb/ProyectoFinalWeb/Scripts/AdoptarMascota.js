window.onload = function () {

    fetch('https://localhost:44343/api/ConsultarAnimalesParaAdopcion')
        .then(response => response.json())
        .then(data => {
            // Populate the dropdown with the list of animals
            const dropdown = document.getElementById('animalList');
            data.forEach(animal => {
                const option = document.createElement('option');
                option.text = animal.nombre;
                option.value = animal.id;
                dropdown.add(option);
            });
        })
        .catch(error => console.error('Error:', error));

}


function submitAnimal() {
    const selectedAnimal = document.getElementById("animalList").value;
    const userid = document.getElementById("userid").textContent;
    console.log("selectedAnimal", selectedAnimal);
    console.log("userid", userid);

    const data = {
        animal_ID: selectedAnimal,
        adoptante_ID: userid
    };

    fetch('https://localhost:44343/api/AdoptarMascota', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    })
        .then(response => response.json())
        .then(data => console.log(data))
        .catch(error => console.error(error));

}