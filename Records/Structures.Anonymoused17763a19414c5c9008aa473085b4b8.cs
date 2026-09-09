namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (OnYX7UEZXEyQCKpHMIW0uA)
///  <code>RC_c0133441667bf39f1c8403118864a3c3</code> that represent
/// s <code>IsSelectedSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: IsSelectedSupplierRecord
public partial struct RC_c0133441667bf39f1c8403118864a3c3 : ITypedRecord<RC_c0133441667bf39f1c8403118864a3c3> {
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public bool ssIsSelected;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_c0133441667bf39f1c8403118864a3c3() {
OptimizedAttributes = null;
ssIsSelected = false;
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSupplier.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSupplier.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssIsSelected = r.ReadBoolean(index++, "IsSelectedSupplierRecord.IsSelected", false);
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
public void ReadIM(RC_c0133441667bf39f1c8403118864a3c3 r) {
this = r;
}


public static bool operator == (RC_c0133441667bf39f1c8403118864a3c3 a, RC_c0133441667bf39f1c8403118864a3c3 b) {
if (a.ssIsSelected != b.ssIsSelected) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_c0133441667bf39f1c8403118864a3c3 a, RC_c0133441667bf39f1c8403118864a3c3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c0133441667bf39f1c8403118864a3c3)) return false;
return (this == (RC_c0133441667bf39f1c8403118864a3c3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIsSelected.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSupplier.InternalRecursiveSave();
}


public RC_c0133441667bf39f1c8403118864a3c3 Duplicate() {
RC_c0133441667bf39f1c8403118864a3c3 t;
t.ssIsSelected = this.ssIsSelected;
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
if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
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
if (key == IdIsSelected) {
return ssIsSelected;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_c0133441667bf39f1c8403118864a3c3
/// <summary>
/// RecordList type <code>IsSelectedSupplierRecordList</code> that represents a record list of
///  <code>Boolean, Supplier</code>
/// </summary>
public partial class RL_53ee8acf49c9618a86f040a6ab1ebb06 : GenericRecordList<RC_c0133441667bf39f1c8403118864a3c3>, IEnumerable, IEnumerator {

protected override RC_c0133441667bf39f1c8403118864a3c3 GetElementDefaultValue() {
return new RC_c0133441667bf39f1c8403118864a3c3();
}

public T[] ToArray<T>(Func<RC_c0133441667bf39f1c8403118864a3c3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_53ee8acf49c9618a86f040a6ab1ebb06 recordList, Func<RC_c0133441667bf39f1c8403118864a3c3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_53ee8acf49c9618a86f040a6ab1ebb06(RC_c0133441667bf39f1c8403118864a3c3[] array) {
  RL_53ee8acf49c9618a86f040a6ab1ebb06 result = new RL_53ee8acf49c9618a86f040a6ab1ebb06();
result.InnerFromArray(array);
    return result;
}

public static RL_53ee8acf49c9618a86f040a6ab1ebb06 ToList<T>(T[] array, Func <T, RC_c0133441667bf39f1c8403118864a3c3> converter) {
  RL_53ee8acf49c9618a86f040a6ab1ebb06 result = new RL_53ee8acf49c9618a86f040a6ab1ebb06();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_53ee8acf49c9618a86f040a6ab1ebb06 FromRestList<T>(RestList<T> restList, Func <T, RC_c0133441667bf39f1c8403118864a3c3> converter) {
  RL_53ee8acf49c9618a86f040a6ab1ebb06 result = new RL_53ee8acf49c9618a86f040a6ab1ebb06();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_53ee8acf49c9618a86f040a6ab1ebb06() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c0133441667bf39f1c8403118864a3c3> NewList() {
return new RL_53ee8acf49c9618a86f040a6ab1ebb06();
}


} // RL_53ee8acf49c9618a86f040a6ab1ebb06
}

