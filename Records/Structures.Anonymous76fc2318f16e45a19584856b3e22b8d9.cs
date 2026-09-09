namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (GCP8dm7xoUWVhIVrPiK42Q)
///  <code>RC_9b8bde366f0fe61cf64fff2adf2f6e88</code> that represent
/// s <code>RequisitionSupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionSupplierRegionRecord
public partial struct RC_9b8bde366f0fe61cf64fff2adf2f6e88 : ITypedRecord<RC_9b8bde366f0fe61cf64fff2adf2f6e88> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_9b8bde366f0fe61cf64fff2adf2f6e88() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(28,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENSupplier.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENSupplier.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_9b8bde366f0fe61cf64fff2adf2f6e88 r) {
this = r;
}


public static bool operator == (RC_9b8bde366f0fe61cf64fff2adf2f6e88 a, RC_9b8bde366f0fe61cf64fff2adf2f6e88 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_9b8bde366f0fe61cf64fff2adf2f6e88 a, RC_9b8bde366f0fe61cf64fff2adf2f6e88 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9b8bde366f0fe61cf64fff2adf2f6e88)) return false;
return (this == (RC_9b8bde366f0fe61cf64fff2adf2f6e88)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_9b8bde366f0fe61cf64fff2adf2f6e88 Duplicate() {
RC_9b8bde366f0fe61cf64fff2adf2f6e88 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
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
if (key == IdRequisition) {
return ssENRequisition;
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
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
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
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_9b8bde366f0fe61cf64fff2adf2f6e88
/// <summary>
/// RecordList type <code>RequisitionSupplierRegionRecordList</code> that represents a record list of
///  <code>Requisition, Supplier, Region</code>
/// </summary>
public partial class RL_fb447cbe50933c4990bdca146fda9078 : GenericRecordList<RC_9b8bde366f0fe61cf64fff2adf2f6e88>, IEnumerable, IEnumerator {

protected override RC_9b8bde366f0fe61cf64fff2adf2f6e88 GetElementDefaultValue() {
return new RC_9b8bde366f0fe61cf64fff2adf2f6e88();
}

public T[] ToArray<T>(Func<RC_9b8bde366f0fe61cf64fff2adf2f6e88, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fb447cbe50933c4990bdca146fda9078 recordList, Func<RC_9b8bde366f0fe61cf64fff2adf2f6e88, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fb447cbe50933c4990bdca146fda9078(RC_9b8bde366f0fe61cf64fff2adf2f6e88[] array) {
  RL_fb447cbe50933c4990bdca146fda9078 result = new RL_fb447cbe50933c4990bdca146fda9078();
result.InnerFromArray(array);
    return result;
}

public static RL_fb447cbe50933c4990bdca146fda9078 ToList<T>(T[] array, Func <T, RC_9b8bde366f0fe61cf64fff2adf2f6e88> converter) {
  RL_fb447cbe50933c4990bdca146fda9078 result = new RL_fb447cbe50933c4990bdca146fda9078();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fb447cbe50933c4990bdca146fda9078 FromRestList<T>(RestList<T> restList, Func <T, RC_9b8bde366f0fe61cf64fff2adf2f6e88> converter) {
  RL_fb447cbe50933c4990bdca146fda9078 result = new RL_fb447cbe50933c4990bdca146fda9078();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fb447cbe50933c4990bdca146fda9078() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(58,false);
def[1] = new BitArray(28,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9b8bde366f0fe61cf64fff2adf2f6e88> NewList() {
return new RL_fb447cbe50933c4990bdca146fda9078();
}


} // RL_fb447cbe50933c4990bdca146fda9078
}

