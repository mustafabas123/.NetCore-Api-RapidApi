﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet Başlık giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet Açıklama giriniz")]
        public string Description { get; set; }
    }
}
