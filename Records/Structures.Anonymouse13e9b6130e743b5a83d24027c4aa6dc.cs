namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (YZs+4ecwtUOoPSQCfEqm3A)
///  <code>RC_77f38836e79eb884191ad814597e8589</code> that represent
/// s <code>OrderMainOrderDetailCompanySupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainOrderDetailCompanySupplierRegionRecord
public partial struct RC_77f38836e79eb884191ad814597e8589 : ITypedRecord<RC_77f38836e79eb884191ad814597e8589> {
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_77f38836e79eb884191ad814597e8589() {
OptimizedAttributes = null;
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(29,false);
    all[1] = new BitArray(39,false);
    all[2] = new BitArray(11,false);
    all[3] = new BitArray(28,false);
    all[4] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENOrderMain.OptimizedAttributes = value[0];
    ssENOrderDetail.OptimizedAttributes = value[1];
    ssENCompany.OptimizedAttributes = value[2];
    ssENSupplier.OptimizedAttributes = value[3];
    ssENRegion.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENOrderMain.OptimizedAttributes;
    all[1] = ssENOrderDetail.OptimizedAttributes;
    all[2] = ssENCompany.OptimizedAttributes;
    all[3] = ssENSupplier.OptimizedAttributes;
    all[4] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_77f38836e79eb884191ad814597e8589 r) {
this = r;
}


public static bool operator == (RC_77f38836e79eb884191ad814597e8589 a, RC_77f38836e79eb884191ad814597e8589 b) {
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_77f38836e79eb884191ad814597e8589 a, RC_77f38836e79eb884191ad814597e8589 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_77f38836e79eb884191ad814597e8589)) return false;
return (this == (RC_77f38836e79eb884191ad814597e8589)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
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
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_77f38836e79eb884191ad814597e8589 Duplicate() {
RC_77f38836e79eb884191ad814597e8589 t;
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
if (head == "ordermain") {
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
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_77f38836e79eb884191ad814597e8589
/// <summary>
/// RecordList type <code>OrderMainOrderDetailCompanySupplierRegionRecordList</code> that represents a
///  record list of <code>OrderMain, OrderDetail, Company, Supplier, Region</code>
/// </summary>
public partial class RL_9399cd7e3fe138caf31a0e1fae937d4b : GenericRecordList<RC_77f38836e79eb884191ad814597e8589>, IEnumerable, IEnumerator {

protected override RC_77f38836e79eb884191ad814597e8589 GetElementDefaultValue() {
return new RC_77f38836e79eb884191ad814597e8589();
}

public T[] ToArray<T>(Func<RC_77f38836e79eb884191ad814597e8589, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9399cd7e3fe138caf31a0e1fae937d4b recordList, Func<RC_77f38836e79eb884191ad814597e8589, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9399cd7e3fe138caf31a0e1fae937d4b(RC_77f38836e79eb884191ad814597e8589[] array) {
  RL_9399cd7e3fe138caf31a0e1fae937d4b result = new RL_9399cd7e3fe138caf31a0e1fae937d4b();
result.InnerFromArray(array);
    return result;
}

public static RL_9399cd7e3fe138caf31a0e1fae937d4b ToList<T>(T[] array, Func <T, RC_77f38836e79eb884191ad814597e8589> converter) {
  RL_9399cd7e3fe138caf31a0e1fae937d4b result = new RL_9399cd7e3fe138caf31a0e1fae937d4b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9399cd7e3fe138caf31a0e1fae937d4b FromRestList<T>(RestList<T> restList, Func <T, RC_77f38836e79eb884191ad814597e8589> converter) {
  RL_9399cd7e3fe138caf31a0e1fae937d4b result = new RL_9399cd7e3fe138caf31a0e1fae937d4b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9399cd7e3fe138caf31a0e1fae937d4b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(29,false);
def[1] = new BitArray(39,false);
def[2] = new BitArray(11,false);
def[3] = new BitArray(28,false);
def[4] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_77f38836e79eb884191ad814597e8589> NewList() {
return new RL_9399cd7e3fe138caf31a0e1fae937d4b();
}


} // RL_9399cd7e3fe138caf31a0e1fae937d4b
}

