﻿import { validateEmail } from './utils';

new Vue({
    el: '#form',
    data: {
        FullName: '',
        Email: '',
        Age: '',
        Gender: '',
        InvalidEmail: false
    },
    computed: {
        isSubmitDisabled() {
            let isDisabled = true;

            if (
                this.FullName !== '' &&
                 this.Email !== '' &&
                this.Age !== '' &&
                this.Gender !== ''
            ) {
                isDisabled = false;
            }

            return isDisabled;
        }
    },
    methods: {
        ResetForm() {
            this.FullName = '';
            this.Email = '';
            this.Age = '';
            this.Gender = '';
        },
        SubmitForm() {
            let submit = true;

            if (!validateEmail(this.Email)) {
                this.InvalidEmail = true;
                submit = false;
            } else {
                this.InvalidEmail = false;
            }

            if (submit) {
                axios({
                    method: 'post',
                    url: '/Home/SubmitedForm',
                    data: { "PersonalInfo": this.$data }
                }).then(res => {
                    alert('Successfully saved information! ');
                    this.$refs.SubmitButton.setAttribute("disabled", "disabled");
                }).catch(err => {
                    alert(`There was an error submitting your form. See details: ${err}`);
                });
            }
        },
        CheckEmail() {
            if (!validateEmail(this.Email)) {
                this.InvalidEmail = true;
                submit = false;
            } else {
                this.InvalidEmail = false;
            }
        }
    }
});