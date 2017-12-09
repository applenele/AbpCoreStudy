﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpCoreStudy.MultiTenancy.Dto;

namespace AbpCoreStudy.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
