import axios from 'axios';

const client = axios.create({
    baseURL: 'https://localhost:44369/api/',
    json: true
})  

  export default {
    async execute(method, resource, data) {
        return client({
          method,
          url: resource,
          data,
        }).then(req => {
          return req.data
        })
      },
    getAllData(page,RowPerPage){
      return client.get(`CustomerSupport/all/${page}/${RowPerPage}`);
        //return this.execute('get','CustomerSupport/all');
    },
    getTotal(){
      return this.execute('get','CustomerSupport/total');
    },
    getAllDataLoaiVanDe(){
        return this.execute('get','CustomerSupport/dslvde');
    },
    insertdata(data) {
        return this.execute('post','CustomerSupport/insert', data)
    },
    updatedata(data) {
      return this.execute('put','CustomerSupport/update', data)
    },
    delete(id){
      return client.delete(`CustomerSupport/delete/${id}`);
    },
    getDataById(id){
      return client.get(`CustomerSupport/getid/${id}`);
    },
  }