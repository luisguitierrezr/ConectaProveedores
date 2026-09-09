namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (DU4hoGRnnUG7OPoV2gCEhw)
///  <code>RC_4934ec74dc6a80637b84c0985f5b12ce</code> that represents <code>SupplierRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SupplierRecord
public partial struct RC_4934ec74dc6a80637b84c0985f5b12ce : ITypedRecord<RC_4934ec74dc6a80637b84c0985f5b12ce> {
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public static implicit operator EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord( RC_4934ec74dc6a80637b84c0985f5b12ce r) {
return r.ssENSupplier;
}

public static implicit operator RC_4934ec74dc6a80637b84c0985f5b12ce (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord r) {
RC_4934ec74dc6a80637b84c0985f5b12ce res = new RC_4934ec74dc6a80637b84c0985f5b12ce ();
res.ssENSupplier = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSupplier.ChangedAttributes = value;
}
get {
    return ssENSupplier.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_4934ec74dc6a80637b84c0985f5b12ce() {
OptimizedAttributes = null;
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
public void ReadIM(RC_4934ec74dc6a80637b84c0985f5b12ce r) {
this = r;
}


public static bool operator == (RC_4934ec74dc6a80637b84c0985f5b12ce a, RC_4934ec74dc6a80637b84c0985f5b12ce b) {
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_4934ec74dc6a80637b84c0985f5b12ce a, RC_4934ec74dc6a80637b84c0985f5b12ce b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4934ec74dc6a80637b84c0985f5b12ce)) return false;
return (this == (RC_4934ec74dc6a80637b84c0985f5b12ce)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
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


public RC_4934ec74dc6a80637b84c0985f5b12ce Duplicate() {
RC_4934ec74dc6a80637b84c0985f5b12ce t;
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
if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSupplier.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSupplier.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_4934ec74dc6a80637b84c0985f5b12ce
/// <summary>
/// RecordList type <code>SupplierRecordList</code> that represents a record list of
///  <code>Supplier</code>
/// </summary>
public partial class RL_d5c1b2482ff109e80580d8b5fb920193 : GenericRecordList<RC_4934ec74dc6a80637b84c0985f5b12ce>, IEnumerable, IEnumerator {

protected override RC_4934ec74dc6a80637b84c0985f5b12ce GetElementDefaultValue() {
return new RC_4934ec74dc6a80637b84c0985f5b12ce();
}

public T[] ToArray<T>(Func<RC_4934ec74dc6a80637b84c0985f5b12ce, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d5c1b2482ff109e80580d8b5fb920193 recordList, Func<RC_4934ec74dc6a80637b84c0985f5b12ce, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d5c1b2482ff109e80580d8b5fb920193(RC_4934ec74dc6a80637b84c0985f5b12ce[] array) {
  RL_d5c1b2482ff109e80580d8b5fb920193 result = new RL_d5c1b2482ff109e80580d8b5fb920193();
result.InnerFromArray(array);
    return result;
}

public static RL_d5c1b2482ff109e80580d8b5fb920193 ToList<T>(T[] array, Func <T, RC_4934ec74dc6a80637b84c0985f5b12ce> converter) {
  RL_d5c1b2482ff109e80580d8b5fb920193 result = new RL_d5c1b2482ff109e80580d8b5fb920193();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d5c1b2482ff109e80580d8b5fb920193 FromRestList<T>(RestList<T> restList, Func <T, RC_4934ec74dc6a80637b84c0985f5b12ce> converter) {
  RL_d5c1b2482ff109e80580d8b5fb920193 result = new RL_d5c1b2482ff109e80580d8b5fb920193();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d5c1b2482ff109e80580d8b5fb920193() : base() {
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
protected override OSList<RC_4934ec74dc6a80637b84c0985f5b12ce> NewList() {
return new RL_d5c1b2482ff109e80580d8b5fb920193();
}


} // RL_d5c1b2482ff109e80580d8b5fb920193
}

