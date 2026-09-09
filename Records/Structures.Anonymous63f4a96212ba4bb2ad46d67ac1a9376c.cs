namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Yqn0Y7oSskutRtZ6wak3bA)
///  <code>RC_c300d864ed706a5a026b7eea8a29e521</code> that represent
/// s
///  <code>CurrencyUserRequisitionUser_Extended_InternalCompanySupplierPaymentTermsPaymentMethodsRegionR
/// ecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyUserRequisitionUser_Extended_InternalCompanySupplierPaymentTermsPaymentMethodsRegionRecord
public partial struct RC_c300d864ed706a5a026b7eea8a29e521 : ITypedRecord<RC_c300d864ed706a5a026b7eea8a29e521> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");
internal static readonly GlobalObjectKey IdPaymentMethods = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GI4gRZFLoSpiPN8Zdg6Ofg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public ENUserEntityRecord ssENUser;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;

public EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord ssENPaymentMethods;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_c300d864ed706a5a026b7eea8a29e521() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENUser = new ENUserEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
ssENPaymentMethods = new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[9];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(58,false);
    all[3] = new BitArray(20,false);
    all[4] = new BitArray(11,false);
    all[5] = new BitArray(28,false);
    all[6] = new BitArray(11,false);
    all[7] = new BitArray(9,false);
    all[8] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENPaymentMethods.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENUser.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    ssENUser_Extended_Internal.OptimizedAttributes = value[3];
    ssENCompany.OptimizedAttributes = value[4];
    ssENSupplier.OptimizedAttributes = value[5];
    ssENPaymentTerms.OptimizedAttributes = value[6];
    ssENPaymentMethods.OptimizedAttributes = value[7];
    ssENRegion.OptimizedAttributes = value[8];
    }
}
get{
    BitArray[] all = new BitArray[9];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENUser.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    all[3] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[4] = ssENCompany.OptimizedAttributes;
    all[5] = ssENSupplier.OptimizedAttributes;
    all[6] = ssENPaymentTerms.OptimizedAttributes;
    all[7] = ssENPaymentMethods.OptimizedAttributes;
    all[8] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssENUser.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENPaymentTerms.Read( r, ref index);
ssENPaymentMethods.Read( r, ref index);
ssENRegion.Read( r, ref index);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(RC_c300d864ed706a5a026b7eea8a29e521 r) {
this = r;
}


public static bool operator == (RC_c300d864ed706a5a026b7eea8a29e521 a, RC_c300d864ed706a5a026b7eea8a29e521 b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
if (a.ssENPaymentMethods != b.ssENPaymentMethods) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_c300d864ed706a5a026b7eea8a29e521 a, RC_c300d864ed706a5a026b7eea8a29e521 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c300d864ed706a5a026b7eea8a29e521)) return false;
return (this == (RC_c300d864ed706a5a026b7eea8a29e521)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
 ^ ssENPaymentMethods.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENUser.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENPaymentTerms.RecursiveReset();
ssENPaymentMethods.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENUser.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENPaymentTerms.InternalRecursiveSave();
ssENPaymentMethods.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_c300d864ed706a5a026b7eea8a29e521 Duplicate() {
RC_c300d864ed706a5a026b7eea8a29e521 t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENPaymentTerms = (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord)this.ssENPaymentTerms.Duplicate();
t.ssENPaymentMethods = (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord)this.ssENPaymentMethods.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "paymentterms") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTerms")) variable.Value = ssENPaymentTerms; else variable.Optimized = true;
variable.SetFieldName("paymentterms");
} else if (head == "paymentmethods") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentMethods")) variable.Value = ssENPaymentMethods; else variable.Optimized = true;
variable.SetFieldName("paymentmethods");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdUser) {
return ssENUser;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdPaymentTerms) {
return ssENPaymentTerms;
}
if (key == IdPaymentMethods) {
return ssENPaymentMethods;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdPaymentTerms.Key.AsGuid) {
return ssENPaymentTerms;
}
if (attributeKey == IdPaymentMethods.Key.AsGuid) {
return ssENPaymentMethods;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
ssENPaymentMethods.FillFromOther((IRecord) other.AttributeGet(IdPaymentMethods));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_c300d864ed706a5a026b7eea8a29e521
/// <summary>
/// RecordList type
///  <code>CurrencyUserRequisitionUser_Extended_InternalCompanySupplierPaymentTermsPaymentMethodsRegionR
/// ecordList</code> that represents a record list of <code>Currency, User, Requisition,
///  User_Extended_Internal, Company, Supplier, PaymentTerms, PaymentMethods, Region</code>
/// </summary>
public partial class RL_b18851832343d010b62ce1bd6ac93765 : GenericRecordList<RC_c300d864ed706a5a026b7eea8a29e521>, IEnumerable, IEnumerator {

protected override RC_c300d864ed706a5a026b7eea8a29e521 GetElementDefaultValue() {
return new RC_c300d864ed706a5a026b7eea8a29e521();
}

public T[] ToArray<T>(Func<RC_c300d864ed706a5a026b7eea8a29e521, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b18851832343d010b62ce1bd6ac93765 recordList, Func<RC_c300d864ed706a5a026b7eea8a29e521, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b18851832343d010b62ce1bd6ac93765(RC_c300d864ed706a5a026b7eea8a29e521[] array) {
  RL_b18851832343d010b62ce1bd6ac93765 result = new RL_b18851832343d010b62ce1bd6ac93765();
result.InnerFromArray(array);
    return result;
}

public static RL_b18851832343d010b62ce1bd6ac93765 ToList<T>(T[] array, Func <T, RC_c300d864ed706a5a026b7eea8a29e521> converter) {
  RL_b18851832343d010b62ce1bd6ac93765 result = new RL_b18851832343d010b62ce1bd6ac93765();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b18851832343d010b62ce1bd6ac93765 FromRestList<T>(RestList<T> restList, Func <T, RC_c300d864ed706a5a026b7eea8a29e521> converter) {
  RL_b18851832343d010b62ce1bd6ac93765 result = new RL_b18851832343d010b62ce1bd6ac93765();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b18851832343d010b62ce1bd6ac93765() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[9];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(58,false);
def[3] = new BitArray(20,false);
def[4] = new BitArray(11,false);
def[5] = new BitArray(28,false);
def[6] = new BitArray(11,false);
def[7] = new BitArray(9,false);
def[8] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c300d864ed706a5a026b7eea8a29e521> NewList() {
return new RL_b18851832343d010b62ce1bd6ac93765();
}


} // RL_b18851832343d010b62ce1bd6ac93765
}

