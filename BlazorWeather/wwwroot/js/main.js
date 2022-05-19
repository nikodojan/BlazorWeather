/**
 * Wrap function in a Promise.
 * Resolve when position is found.
 * Reject when error occurs.
 */
const getLocation = () => new Promise(
    (resolve, reject) => {
        window.navigator.geolocation.getCurrentPosition(
            position => {
                const location = {
                    lat: position.coords.latitude,
                    lon: position.coords.longitude
                };
                resolve(location); // Resolve with location. location can now be accessed in the .then method.
            }, 
            err => resolve({ lat: 55.6733995892128, lon: 12.565123825679906 }) // Reject with err. err can now be accessed in the .catch method.
        );
    }
);

/**
 * then is called when the Promise is resolved
 * catch is called when the Promise rejects or encounters an error.
 */
getLocation()
    .then(location => { return location });

async function getloc() {
    var p = await getLocation();
    return p;
}