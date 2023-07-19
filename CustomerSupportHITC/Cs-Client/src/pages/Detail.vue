<template>
    <div class="q-pa-md q-gutter-sm">
    <q-form @submit="onSubmit" @reset="onReset">
        <div class="row justify-between">
            <div class="col-12 col-md-7">
                <div class="text-h6">THÔNG TIN CHUNG</div>
                <div class="row">
                <div class="col-12 col-md-12">
                    <q-select
                    class="q-mr-sm"
                    filled
                    v-model="modelAdd.idLoaiVanDe"
                    :options="OptionsVanDe"
                    label="Phân loại *"
                    emit-value
                    map-options
                    lazy-rules
                    :rules="[ va => val && val.length > 0 || 'Hãy chọn loại vấn đề']"
                    />
                </div>
                </div>
                <div class="row">
                <div class="col-12 col-md-6">
                    <q-select
                    class="q-mr-sm"
                    filled
                    v-model="modelAdd.MucDoUuTien"
                    :options="OptionsUuTien"
                    label="Mức độ ưu tiên *"
                    emit-value
                    map-options
                    lazy-rules
                    :rules="[ val => val && val.length > 0 || 'Hãy chọn mức độ ưu tiên']"
                    />
                </div>
                <div class="col-12 col-md-6">
                    <q-select
                    class="q-mr-sm"
                    filled
                    v-model="modelAdd.TrangThai"
                    :options="OptionsTinhTrang"
                    label="Tình trạng *"
                    emit-value
                    map-options
                    lazy-rules
                    :rules="[ val => val && val.length > 0 || 'Hãy chọn tình trạng']"
                    />
                </div>
                </div>
                <div class="row">
                <div class="col-12 col-md-6">
                    <q-input
                    filled
                    class="q-mr-sm"
                    v-model="modelAdd.SoDienThoai"
                    label="SĐT *"
                    lazy-rules
                    :rules="[ val => val && val.length > 0 || 'Hãy nhập số điện thoại']"
                    />
                </div>
                </div>
                <div class="row">
                <div class="col-12 col-md-12">
                    <q-input
                    filled
                    class="q-mr-sm"
                    v-model="modelAdd.TenKhachHang"
                    label="Tên khách hàng *"
                    lazy-rules
                    :rules="[ val => val && val.length > 0 || 'Hãy nhập tên khách hàng']"
                    />
                </div>
                </div>
                <div class="row">
                <div class="col-12 col-md-12">
                    <q-input
                    filled
                    class="q-mr-sm"
                    v-model="modelAdd.DiaChi"
                    label="Địa chỉ"
                    type="textarea"
                    lazy-rules
                    />
                </div>
                </div>
                <div class="row">
                <div class="col-12 col-md-12 q-mt-md">
                    <q-input
                    filled
                    class="q-mr-sm"
                    v-model="modelAdd.NoiDung"
                    label="Nội dung"
                    type="textarea"
                    />
                </div>
                </div>
                <div class="row">
                <div class="col-12 col-md-12 q-mt-md">
                    <q-input
                    filled
                    class="q-mr-sm"
                    v-model="modelAdd.TraLoi"
                    label="Trả lời"
                    type="textarea"
                    lazy-rules
                    />
                </div>
                </div>
                <div class="row q-mt-md">
                <div class="text-h6">ĐÁNH GIÁ CỦA KHÁCH HÀNG</div>
                </div>
                <div class="row">
                <div class="col-12 col-md-12 q-mt-md">
                    <q-input
                    filled
                    class="q-mr-sm"
                    v-model="modelAdd.YKienKhachHang"
                    label="Ý kiến"
                    type="textarea"
                    lazy-rules
                    />
                </div>
                </div>
                <div class="row">
                <div class="col-12 col-md-6 q-mt-md">
                    <q-select
                    class="q-mr-sm"
                    filled
                    v-model="modelAdd.DanhGiaKhachHang"
                    :options="OptionStar"
                    emit-value
                    map-options
                    label="Đánh giá"
                    />
                </div>
                </div>
            </div>
        <div class="col-12 col-md-4 ">
            <div class="text-h6">TIẾN ĐỘ</div>
            <div class="row">
            <div class="col-12 col-md-12">
                <q-input
                class="q-mr-sm"
                filled
                v-model="modelAdd.NguoiXuLy"
                label="Người xử lý *"
                lazy-rules
                :rules="[ val => val && val.length > 0 || 'Hãy nhập người xử lý']"
                />
            </div>
            </div>
            <div class="row">
            <div class="col-12 col-md-12">
                <q-input
                class="q-mr-sm"
                filled
                v-model="modelAdd.NguoiTao"
                label="Người tạo *"
                lazy-rules
                :rules="[ val => val && val.length > 0 || 'Hãy nhập người tạo']"
                />
            </div>
            </div>
            <div class="row">
            <div class="col-12 col-md-12">
                <q-input filled v-model="modelAdd.NgayTao" mask="date" :rules="['date']" label="Ngày tạo *" class="q-mr-sm">
                <template v-slot:append>
                    <q-icon name="event" class="cursor-pointer">
                    <q-popup-proxy cover transition-show="scale" transition-hide="scale">
                        <q-date v-model="modelAdd.NgayTao">
                        <div class="row items-center justify-end">
                            <q-btn v-close-popup label="Close" color="primary" flat />
                        </div>
                        </q-date>
                    </q-popup-proxy>
                    </q-icon>
                </template>
                </q-input>
            </div>
            </div>
            <div class="row">
            <div class="col-12 col-md-12">
                <q-input filled v-model="modelAdd.NgayHoanThanh" mask="date" :rules="['date']" label="Ngày hoàn thành *" class="q-mr-sm">
                <template v-slot:append>
                    <q-icon name="event" class="cursor-pointer">
                    <q-popup-proxy cover transition-show="scale" transition-hide="scale">
                        <q-date v-model="modelAdd.NgayHoanThanh">
                        <div class="row items-center justify-end">
                            <q-btn v-close-popup label="Close" color="primary" flat />
                        </div>
                        </q-date>
                    </q-popup-proxy>
                    </q-icon>
                </template>
                </q-input>
            </div>
            </div>
        </div>
        </div>
    <div class="q-mt-md">
      <q-btn label="Lưu" type="submit" color="primary" @click="onSubmit"/>
      <q-btn label="Hủy" type="reset" color="negative" class="q-ml-sm" @click="$router.replace({name: 'index'});"/>
    </div>
    </q-form>
</div>
</template>
<script>
    import { defineComponent, ref } from 'vue'
    import api from '../app'
    import { useQuasar } from 'quasar'
    export default defineComponent({
        name: 'Detail',
        setup () {
            const $q = useQuasar()
            return{
                OptionsTinhTrang: [
                    {
                    label: 'Open',
                    value: 'T'
                    },
                    {
                    label: 'Close',
                    value: 'F'
                    }
                ],
                OptionsUuTien: [
                    {
                    label: 'Thấp',
                    value: 'L'
                    },
                    {
                    label: 'Trung bình',
                    value: 'N'
                    },
                    {
                    label: 'Cao',
                    value: 'H'
                    }
                ],
                OptionStar: [
                    {
                    label: '1 Sao',
                    value: 1
                    },
                    {
                    label: '2 Sao',
                    value: '2'
                    },
                    {
                    label: '3 Sao',
                    value: '3'
                    },
                    {
                    label: '4 Sao',
                    value: '4'
                    },
                    {
                    label: '5 Sao',
                    value: '5'
                    }
                ],
                date: ref('2019/02/01'),
                
            }
        },
        data() {
            return {
                loading: false,
                OptionsVanDe: [],
                modelAdd: {}
            };
        },
        async created() {
            await this.getDataLoaiVanDe()
        },
        methods: {
            
            onSubmit() {
                api.insertdata(this.modelAdd).then(() => this.$q.notify({
                    type: 'positive',
                    message: 'Cập nhật dữ liệu thành công'
                }).catch((error) => this.$q.notify({
                    type: 'negative',
                    message: 'Cập nhật dữ liệu thất  bại'
                })));
                this.modelAdd = {}
                this.$router.replace({name: 'index'});
            },
            async getDataLoaiVanDe () {
                let response 
                response = await api.getAllDataLoaiVanDe().then(() => this.$q.notify({
                    type: 'positive',
                    message: 'Lấy dữ liệu thành công'
                }).catch((error) => this.$q.notify({
                    type: 'negative',
                    message: 'Lấy dữ liệu thất  bại'
                })));
                response.forEach((item, index) => {
                    this.OptionsVanDe.push({
                        label: item.tenLoaiVanDe,
                        value: item.id
                    })
                })
            }
        }
    })
</script>