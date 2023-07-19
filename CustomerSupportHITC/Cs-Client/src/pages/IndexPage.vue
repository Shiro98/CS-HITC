<template>
  <div class="q-pa-md q-gutter-sm">
    <q-btn color="primary" label="Thêm" @click="$router.replace({name: 'detail'})"/>
    <q-btn color="primary" label="Xuất Excel" />
    <q-table
      flat bordered
      title="DANH SÁCH VẤN ĐỀ CỦA CS"
      :rows="data"
      :columns="columns"
      :loading="loading"
      :filter="filter"
      row-key="name"
      v-model:pagination.sync="pagination"
      @request="fetchData"
    >
      <template v-slot:body="props">
        <q-tr :props="props">
          <q-td key="tenLoaiVanDe" :props="props">{{ props.row.tenLoaiVanDe }}</q-td>
          <q-td key="soDienThoai" :props="props">{{ props.row.soDienThoai }}</q-td>
          <q-td key="tenKhachHang" :props="props" @click="$router.push({
                name: 'detailedit',
                params: {'id': props.row.id}
            })">
            {{ props.row.tenKhachHang }}
          </q-td>
          <q-td key="diaChi" :props="props">{{ props.row.diaChi }}</q-td>
          <q-td key="noiDung" :props="props">{{ props.row.noiDung }}</q-td>
          <q-td key="traLoi" :props="props">{{ props.row.traLoi }}</q-td>
          <q-td key="nguoiTao" :props="props">{{ props.row.nguoiTao }}</q-td>
          <q-td key="ngayTao" :props="props">{{ props.row.ngayTao }}</q-td>
          <q-td key="ngayHoanThanh" :props="props">{{ props.row.ngayHoanThanh }}</q-td>
          <q-td key="ChucNang" :props="props">
            <q-btn
            round
            color="negative"
            size="sm"
            icon="delete"
            @click="confirm(props.row.id)"
            />
          </q-td>
        </q-tr>
      </template>
      <template v-slot:top-right>
        <q-input borderless dense debounce="300" v-model="filter" placeholder="Search">
          <template v-slot:append>
            <q-icon name="search" />
          </template>
        </q-input>
      </template>
    </q-table>
    
  </div>
</template>

<script>
import { defineComponent, ref } from 'vue'
import api from '../app'
import { useQuasar } from 'quasar'
// import { data } from 'autoprefixer';
export default defineComponent({
  name: 'IndexPage',
  setup () {
    const $q = useQuasar()
    // var pagination = ref({
    //   descending: false,
    //   page: 1,
    //   rowsPerPage: 3,
    //   rowsNumber: 0
    // })
    function confirm (idx) { 
      $q.dialog({
        title: 'Xác nhận',
        message: 'Bạn chắn chắn muốn xóa dữ liệu?',
        cancel: true,
        persistent: true
      }).onOk(() => {
        this.data = api.delete(idx).catch((error) => this.$q.notify({
                    type: 'negative',
                    message: 'Xóa dữ liệu thất  bại'
                }))
                .finally(() => this.$q.notify({
                    type: 'positive',
                    message: 'Xóa dữ liệu thành công'
                }));
        // console.log('>>>> OK')
      }).onOk(() => {
        // console.log('>>>> second OK catcher')
      }).onCancel(() => {
        // console.log('>>>> Cancel')
      }).onDismiss(() => {
        // console.log('I am triggered on both OK and Cancel')
      })
    }
    
    return {
      //[
      //   {
      //     tinhTrangModel: null,
      //     uuTienModel: null,
      //     starModel: null,
      //     vanDeModel: null,
      //     sdtModel: null,
      //     tenKhachHangModel: null,
      //     diaChiModel: null,
      //     noiDungModel: null,
      //     traLoiModel: null,
      //     yKienModel: null,
      //     nguoiXulyModel: null,
      //     nguoiTaoModel: null,
      //     ngayTaoModel: null,
      //     ngayHoanThanhModel: null
      //   }
      // ],
      rows: [],
      filter: ref(''),
      confirm,
      //pagination,
      // pagination: ref({
      //   descending: false,
      //   page: 1,
      //   rowsPerPage: 3,
      //   rowsNumber: 0
      // }),
      columns: [
        {
          name: 'tenLoaiVanDe',
          label: 'Loại vấn đề',
          align: 'left',
          field: 'tenLoaiVanDe'
          // field: row => row.name,
          // format: val => `${val}`,
          // sortable: true
        },
        { name: 'soDienThoai', align: 'center', label: 'SĐT', field: 'soDienThoai'},
        { name: 'tenKhachHang', label: 'Tên Khách Hàng', field: 'tenKhachHang'},
        { name: 'diaChi', label: 'Địa chỉ', field: 'diaChi' },
        { name: 'noiDung', label: 'Nội dung', field: 'noiDung' },
        { name: 'traLoi', label: 'Trả lời', field: 'traLoi' },
        { name: 'nguoiTao', label: 'Người tạo', field: 'nguoiTao'},
        { name: 'ngayTao', label: 'Ngày Tạo', field: 'ngayTao'},
        { name: 'ngayHoanThanh', label: 'Ngày Hoàn Thành', field: 'ngayHoanThanh'},
        { name: 'ChucNang', label: 'Chức Năng', field: 'ChucNang' }
      ],
      //data: []
    }
  },
  data() {
    return {
      pagination: {
        descending: false,
        page: 1,
        rowsPerPage: 3,
        rowsNumber: 0
      },
      // pagination: {
      //   page: 1,
      //   rowsPerPage: 3,
      //   rowsNumber: 0
      // },
      loading: false,
      data: [],
      
    };
  },
  async created() {
    this.fetchData()
  },
  methods: {
    async fetchData () { // we can specify the "page" to jump to
      //loading.value = true
      // var check;
      api.getTotal().then((result) => {
          this.pagination.rowsNumber = result
      });
      //console.log(check)
      //this.pagination.value.rowsNumber = check 
      api.getAllData(this.pagination.page, this.pagination.rowsPerPage).then((result) => {
                    this.data = result.data
                }).catch((error) => this.$q.notify({
                    type: 'negative',
                    message: 'Lấy dữ liệu thất  bại'
                }))
                .finally(() => this.$q.notify({
                    type: 'positive',
                    message: 'Lấy dữ liệu thành công'
                }));
      console.log(this.data);
    },
    mounted () {
      this.fetchData({
        pagination: this.pagination,
      })
    }
    // async totalData () {

    // },
    // async fetchData () {
    //   let response
    //   // if (this.isOverview) {
    //     this.data = await api.getAllData().catch((error) => this.$q.notify({
    //                 type: 'negative',
    //                 message: 'Lấy dữ liệu thất  bại'
    //             }))
    //             .finally(() => this.$q.notify({
    //                 type: 'positive',
    //                 message: 'Lấy dữ liệu thành công'
    //             }));
    //   //}
    //   //if (response.Status === 200) {
    //     // this.data = response.data.map(d => {
    //     //   return {
    //     //     LoaiVanDe: d.idLoaiVanDe,
    //     //     TenKhachHang: d.tenKhachHang,
    //     //     PhoneNumber: d.soDienThoai
    //     //   }
    //     // })
    //   //}
    // }
  }
})
</script>
