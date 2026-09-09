namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (cUECBh4LYUyOGKqwRLikQw)
///  <code>RC_631f64667ced05b3101507560ed0f622</code> that represent
/// s <code>CompanySupplierSupplierDetailRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: CompanySupplierSupplierDetailRegionRecord
public partial struct RC_631f64667ced05b3101507560ed0f622 : ITypedRecord<RC_631f64667ced05b3101507560ed0f622> {
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdSupplierDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*oEdqKrJCTujdtq2dhvCmhA");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_57ee0c02163ab55038103469b2569162EntityRecord ssENSupplierDetail;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_631f64667ced05b3101507560ed0f622() {
OptimizedAttributes = null;
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENSupplierDetail = new EN_57ee0c02163ab55038103469b2569162EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(11,false);
    all[1] = new BitArray(28,false);
    all[2] = new BitArray(26,false);
    all[3] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENSupplierDetail.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENCompany.OptimizedAttributes = value[0];
    ssENSupplier.OptimizedAttributes = value[1];
    ssENSupplierDetail.OptimizedAttributes = value[2];
    ssENRegion.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENCompany.OptimizedAttributes;
    all[1] = ssENSupplier.OptimizedAttributes;
    all[2] = ssENSupplierDetail.OptimizedAttributes;
    all[3] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENSupplierDetail.Read( r, ref index);
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
public void ReadIM(RC_631f64667ced05b3101507560ed0f622 r) {
this = r;
}


public static bool operator == (RC_631f64667ced05b3101507560ed0f622 a, RC_631f64667ced05b3101507560ed0f622 b) {
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENSupplierDetail != b.ssENSupplierDetail) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_631f64667ced05b3101507560ed0f622 a, RC_631f64667ced05b3101507560ed0f622 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_631f64667ced05b3101507560ed0f622)) return false;
return (this == (RC_631f64667ced05b3101507560ed0f622)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENSupplierDetail.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENSupplierDetail.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENSupplierDetail.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_631f64667ced05b3101507560ed0f622 Duplicate() {
RC_631f64667ced05b3101507560ed0f622 t;
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENSupplierDetail = (EN_57ee0c02163ab55038103469b2569162EntityRecord)this.ssENSupplierDetail.Duplicate();
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
if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "supplierdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierDetail")) variable.Value = ssENSupplierDetail; else variable.Optimized = true;
variable.SetFieldName("supplierdetail");
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
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdSupplierDetail) {
return ssENSupplierDetail;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdSupplierDetail.Key.AsGuid) {
return ssENSupplierDetail;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENSupplierDetail.FillFromOther((IRecord) other.AttributeGet(IdSupplierDetail));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_631f64667ced05b3101507560ed0f622
/// <summary>
/// RecordList type <code>CompanySupplierSupplierDetailRegionRecordList</code> that represents a record
///  list of <code>Company, Supplier, SupplierDetail, Region</code>
/// </summary>
public partial class RL_39c65c63eb449ac42634373c1cc7f81a : GenericRecordList<RC_631f64667ced05b3101507560ed0f622>, IEnumerable, IEnumerator {

protected override RC_631f64667ced05b3101507560ed0f622 GetElementDefaultValue() {
return new RC_631f64667ced05b3101507560ed0f622();
}

public T[] ToArray<T>(Func<RC_631f64667ced05b3101507560ed0f622, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_39c65c63eb449ac42634373c1cc7f81a recordList, Func<RC_631f64667ced05b3101507560ed0f622, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_39c65c63eb449ac42634373c1cc7f81a(RC_631f64667ced05b3101507560ed0f622[] array) {
  RL_39c65c63eb449ac42634373c1cc7f81a result = new RL_39c65c63eb449ac42634373c1cc7f81a();
result.InnerFromArray(array);
    return result;
}

public static RL_39c65c63eb449ac42634373c1cc7f81a ToList<T>(T[] array, Func <T, RC_631f64667ced05b3101507560ed0f622> converter) {
  RL_39c65c63eb449ac42634373c1cc7f81a result = new RL_39c65c63eb449ac42634373c1cc7f81a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_39c65c63eb449ac42634373c1cc7f81a FromRestList<T>(RestList<T> restList, Func <T, RC_631f64667ced05b3101507560ed0f622> converter) {
  RL_39c65c63eb449ac42634373c1cc7f81a result = new RL_39c65c63eb449ac42634373c1cc7f81a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_39c65c63eb449ac42634373c1cc7f81a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(11,false);
def[1] = new BitArray(28,false);
def[2] = new BitArray(26,false);
def[3] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_631f64667ced05b3101507560ed0f622> NewList() {
return new RL_39c65c63eb449ac42634373c1cc7f81a();
}


} // RL_39c65c63eb449ac42634373c1cc7f81a
}

