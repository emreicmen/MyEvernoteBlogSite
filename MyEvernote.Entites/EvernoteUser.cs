﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.Entites
{

    [Table("EvernoteUsers")]
    public class EvernoteUser : MyEntityBase
    {
        [DisplayName("İsim"),
            StringLength(25, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır")]
        public string Name { get; set; }

        [DisplayName("Soyad"),
            StringLength(25, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır")]
        public string Surname { get; set; }

        [DisplayName("Kullanıcı adı"),
            Required(ErrorMessage = "{0} alanı gereklidir."),
            StringLength(25, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır")]
        public string Username { get; set; }

        [DisplayName("E-posta"),
            Required(ErrorMessage = "{0} alanı gereklidir."),
            StringLength(70, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır")]
        public string Email { get; set; }

        [DisplayName("Şifre"),
            Required(ErrorMessage = "{0} alanı gereklidir."),
            StringLength(25, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır")]
        public string Password { get; set; }

        [DisplayName("Is Active")]
        public bool IsActive { get; set; }

        [DisplayName("Profil Resmi"), StringLength(30), ScaffoldColumn(false)] 
        public string ProfileImageFileName { get; set; }

        [Required, ScaffoldColumn(false)]
        public Guid ActiviteGuid { get; set; }

        [DisplayName("Is Admin")]
        public bool IsAdmin { get; set; }

        public virtual List<Note> Notes { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Liked> Likes { get; set; }



    }
}
