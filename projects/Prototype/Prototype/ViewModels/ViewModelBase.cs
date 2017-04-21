﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prototype.ViewModels
{
    /// <summary>
    /// ViewModelの基底クラス。
    /// </summary>
    public class ViewModelBase : IValidatableObject
    {
        /// <summary>
        /// 指定したオブジェクトが有効かどうかを判断します。
        /// </summary>
        /// <param name="validationContext">検証コンテキスト</param>
        /// <returns>検証の失敗の情報を保持するコレクション</returns>
        public virtual IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext)
        {
            return Enumerable.Empty<ValidationResult>();
        }
    }
}