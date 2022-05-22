//controller, get data from API here
//will add auth, posting, editing and all that later

const host = "https://localhost:7037"


async function getAnnouncements() {
    try{
        const res = await axios.get(`${host}/api/Announcement`)
        return res
    } catch(error) {
        console.error(error);
    }
}

async function getAnime() {
    try{
        const res = await axios.get(`${host}/api/Anime`)
        return res
    } catch(error) {
        console.error(error);
    }
}

async function getDownloads() {
    try{
        const res = await axios.get(`${host}/api/Download`)
        return res
    } catch(error) {
        console.error(error);
    }
}

async function getGarbage() {
    try{
        const res = await axios.get(`${host}/api/Garbage`)
        return res
    } catch(error) {
        console.error(error);
    }
}

async function getGranturismo() {
    try{
        const res = await axios.get(`${host}/api/Granturismo`)
        return res
    } catch(error) {
        console.error(error);
    }
}

async function getHentai() {
    try{
        const res = await axios.get(`${host}/api/Hentai`)
        return res
    } catch(error) {
        console.error(error);
    }
}

async function getMisc() {
    try{
        const res = await axios.get(`${host}/api/Misc`)
        return res
    } catch(error) {
        console.error(error);
    }
}

async function getProject() {
    try{
        const res = await axios.get(`${host}/api/Project`)
        return res
    } catch(error) {
        console.error(error);
    }
}

async function getSnippets() {
    try{
        const res = await axios.get(`${host}/api/Snippet`)
        return res
    } catch(error) {
        console.error(error);
    }
}

async function getTune() {
    try{
        const res = await axios.get(`${host}/api/Tune`)
        return res
    } catch(error) {
        console.error(error);
    }
}