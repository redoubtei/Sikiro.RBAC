﻿using System.Collections.Generic;

namespace Sikiro.Web.Admin.Models.Role
{
    public class JurisdictionVo
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Field { get; set; }

        public List<JurisdictionVo> Children { get; set; }

        public bool Spread => true;

        public bool Checked { get; set; }
    }
}
