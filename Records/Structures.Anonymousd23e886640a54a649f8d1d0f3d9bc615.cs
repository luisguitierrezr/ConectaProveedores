namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Zog+0qVAZEqfjR0PPZvGFQ)
///  <code>RC_77723e71a17f336e440e3f9265cbd409</code> that represent
/// s <code>FolioOrderMainOrderDetailCompanySupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioOrderMainOrderDetailCompanySupplierRegionRecord
public partial struct RC_77723e71a17f336e440e3f9265cbd409 : ITypedRecord<RC_77723e71a17f336e440e3f9265cbd409> {
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_77723e71a17f336e440e3f9265cbd409() {
OptimizedAttributes = null;
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(39,false);
    all[3] = new BitArray(11,false);
    all[4] = new BitArray(28,false);
    all[5] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENFolio.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENOrderDetail.OptimizedAttributes = value[2];
    ssENCompany.OptimizedAttributes = value[3];
    ssENSupplier.OptimizedAttributes = value[4];
    ssENRegion.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENFolio.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENOrderDetail.OptimizedAttributes;
    all[3] = ssENCompany.OptimizedAttributes;
    all[4] = ssENSupplier.OptimizedAttributes;
    all[5] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolio.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_77723e71a17f336e440e3f9265cbd409 r) {
this = r;
}


public static bool operator == (RC_77723e71a17f336e440e3f9265cbd409 a, RC_77723e71a17f336e440e3f9265cbd409 b) {
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_77723e71a17f336e440e3f9265cbd409 a, RC_77723e71a17f336e440e3f9265cbd409 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_77723e71a17f336e440e3f9265cbd409)) return false;
return (this == (RC_77723e71a17f336e440e3f9265cbd409)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolio.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolio.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_77723e71a17f336e440e3f9265cbd409 Duplicate() {
RC_77723e71a17f336e440e3f9265cbd409 t;
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_77723e71a17f336e440e3f9265cbd409
/// <summary>
/// RecordList type <code>FolioOrderMainOrderDetailCompanySupplierRegionRecordList</code> that
///  represents a record list of <code>Folio, OrderMain, OrderDetail, Company, Supplier, Region</code>
/// </summary>
public partial class RL_5a56ddde595e36ca6dc14e1cbb3984cb : GenericRecordList<RC_77723e71a17f336e440e3f9265cbd409>, IEnumerable, IEnumerator {

protected override RC_77723e71a17f336e440e3f9265cbd409 GetElementDefaultValue() {
return new RC_77723e71a17f336e440e3f9265cbd409();
}

public T[] ToArray<T>(Func<RC_77723e71a17f336e440e3f9265cbd409, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5a56ddde595e36ca6dc14e1cbb3984cb recordList, Func<RC_77723e71a17f336e440e3f9265cbd409, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5a56ddde595e36ca6dc14e1cbb3984cb(RC_77723e71a17f336e440e3f9265cbd409[] array) {
  RL_5a56ddde595e36ca6dc14e1cbb3984cb result = new RL_5a56ddde595e36ca6dc14e1cbb3984cb();
result.InnerFromArray(array);
    return result;
}

public static RL_5a56ddde595e36ca6dc14e1cbb3984cb ToList<T>(T[] array, Func <T, RC_77723e71a17f336e440e3f9265cbd409> converter) {
  RL_5a56ddde595e36ca6dc14e1cbb3984cb result = new RL_5a56ddde595e36ca6dc14e1cbb3984cb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5a56ddde595e36ca6dc14e1cbb3984cb FromRestList<T>(RestList<T> restList, Func <T, RC_77723e71a17f336e440e3f9265cbd409> converter) {
  RL_5a56ddde595e36ca6dc14e1cbb3984cb result = new RL_5a56ddde595e36ca6dc14e1cbb3984cb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5a56ddde595e36ca6dc14e1cbb3984cb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(20,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(39,false);
def[3] = new BitArray(11,false);
def[4] = new BitArray(28,false);
def[5] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_77723e71a17f336e440e3f9265cbd409> NewList() {
return new RL_5a56ddde595e36ca6dc14e1cbb3984cb();
}


} // RL_5a56ddde595e36ca6dc14e1cbb3984cb
}

