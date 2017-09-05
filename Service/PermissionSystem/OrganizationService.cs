﻿// =================================================================== 
// 项目说明
//====================================================================
// YXL @ CopyRight 2006-2010。
// 文件： OrganizationRespository.cs
// 项目名称： 
// 创建时间：2017-05-18
// 负责人：YXL
// ===================================================================

using System;
using Core.Repository.Ef;
using IService;
using PermissionSystem.Models;
using PermissionSystem;
namespace Service.PermissionSystem
{
    public class OrganizationService  : EfRepository< Organization>,IOrganizationService
    {
      public OrganizationService(PermissionSystemContext context):base(context)
        {
            
        }		
				
    }
}