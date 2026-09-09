namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (O3E4mceZzkmbKfkrcehsng)
///  <code>RC_78028cb3076672e5dc4e3606fbea5d54</code> that represent
/// s <code>RequisitionSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionSupplierRecord
public partial struct RC_78028cb3076672e5dc4e3606fbea5d54 : ITypedRecord<RC_78028cb3076672e5dc4e3606fbea5d54> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_78028cb3076672e5dc4e3606fbea5d54() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENSupplier.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENSupplier.OptimizedAttributes;
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
public void ReadIM(RC_78028cb3076672e5dc4e3606fbea5d54 r) {
this = r;
}


public static bool operator == (RC_78028cb3076672e5dc4e3606fbea5d54 a, RC_78028cb3076672e5dc4e3606fbea5d54 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_78028cb3076672e5dc4e3606fbea5d54 a, RC_78028cb3076672e5dc4e3606fbea5d54 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_78028cb3076672e5dc4e3606fbea5d54)) return false;
return (this == (RC_78028cb3076672e5dc4e3606fbea5d54)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_78028cb3076672e5dc4e3606fbea5d54 Duplicate() {
RC_78028cb3076672e5dc4e3606fbea5d54 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_78028cb3076672e5dc4e3606fbea5d54
/// <summary>
/// RecordList type <code>RequisitionSupplierRecordList</code> that represents a record list of
///  <code>Requisition, Supplier</code>
/// </summary>
public partial class RL_c61f86b789e3e219b8eaddf345441d54 : GenericRecordList<RC_78028cb3076672e5dc4e3606fbea5d54>, IEnumerable, IEnumerator {

protected override RC_78028cb3076672e5dc4e3606fbea5d54 GetElementDefaultValue() {
return new RC_78028cb3076672e5dc4e3606fbea5d54();
}

public T[] ToArray<T>(Func<RC_78028cb3076672e5dc4e3606fbea5d54, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c61f86b789e3e219b8eaddf345441d54 recordList, Func<RC_78028cb3076672e5dc4e3606fbea5d54, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c61f86b789e3e219b8eaddf345441d54(RC_78028cb3076672e5dc4e3606fbea5d54[] array) {
  RL_c61f86b789e3e219b8eaddf345441d54 result = new RL_c61f86b789e3e219b8eaddf345441d54();
result.InnerFromArray(array);
    return result;
}

public static RL_c61f86b789e3e219b8eaddf345441d54 ToList<T>(T[] array, Func <T, RC_78028cb3076672e5dc4e3606fbea5d54> converter) {
  RL_c61f86b789e3e219b8eaddf345441d54 result = new RL_c61f86b789e3e219b8eaddf345441d54();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c61f86b789e3e219b8eaddf345441d54 FromRestList<T>(RestList<T> restList, Func <T, RC_78028cb3076672e5dc4e3606fbea5d54> converter) {
  RL_c61f86b789e3e219b8eaddf345441d54 result = new RL_c61f86b789e3e219b8eaddf345441d54();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c61f86b789e3e219b8eaddf345441d54() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(58,false);
def[1] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_78028cb3076672e5dc4e3606fbea5d54> NewList() {
return new RL_c61f86b789e3e219b8eaddf345441d54();
}


} // RL_c61f86b789e3e219b8eaddf345441d54
}

