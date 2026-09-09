namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (O4TLIiL0RE2jAd8YHK2Jvg)
///  <code>RC_2cc384f6ee3d7a04dad15c303ce7a7a4</code> that represents <code>CFDITypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CFDITypeRecord
public partial struct RC_2cc384f6ee3d7a04dad15c303ce7a7a4 : ITypedRecord<RC_2cc384f6ee3d7a04dad15c303ce7a7a4> {
internal static readonly GlobalObjectKey IdCFDIType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9oTDLD3uBHra0VwwPOenpA");

public EN_f6b1999c25654417411e080987a56a77EntityRecord ssENCFDIType;


public static implicit operator EN_f6b1999c25654417411e080987a56a77EntityRecord( RC_2cc384f6ee3d7a04dad15c303ce7a7a4 r) {
return r.ssENCFDIType;
}

public static implicit operator RC_2cc384f6ee3d7a04dad15c303ce7a7a4 (EN_f6b1999c25654417411e080987a56a77EntityRecord r) {
RC_2cc384f6ee3d7a04dad15c303ce7a7a4 res = new RC_2cc384f6ee3d7a04dad15c303ce7a7a4 ();
res.ssENCFDIType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENCFDIType.ChangedAttributes = value;
}
get {
    return ssENCFDIType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_2cc384f6ee3d7a04dad15c303ce7a7a4() {
OptimizedAttributes = null;
ssENCFDIType = new EN_f6b1999c25654417411e080987a56a77EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCFDIType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCFDIType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCFDIType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCFDIType.Read( r, ref index);
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
public void ReadIM(RC_2cc384f6ee3d7a04dad15c303ce7a7a4 r) {
this = r;
}


public static bool operator == (RC_2cc384f6ee3d7a04dad15c303ce7a7a4 a, RC_2cc384f6ee3d7a04dad15c303ce7a7a4 b) {
if (a.ssENCFDIType != b.ssENCFDIType) return false;
return true;
}

public static bool operator != (RC_2cc384f6ee3d7a04dad15c303ce7a7a4 a, RC_2cc384f6ee3d7a04dad15c303ce7a7a4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2cc384f6ee3d7a04dad15c303ce7a7a4)) return false;
return (this == (RC_2cc384f6ee3d7a04dad15c303ce7a7a4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCFDIType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCFDIType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCFDIType.InternalRecursiveSave();
}


public RC_2cc384f6ee3d7a04dad15c303ce7a7a4 Duplicate() {
RC_2cc384f6ee3d7a04dad15c303ce7a7a4 t;
t.ssENCFDIType = (EN_f6b1999c25654417411e080987a56a77EntityRecord)this.ssENCFDIType.Duplicate();
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
if (head == "cfditype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CFDIType")) variable.Value = ssENCFDIType; else variable.Optimized = true;
variable.SetFieldName("cfditype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENCFDIType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENCFDIType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCFDIType) {
return ssENCFDIType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCFDIType.Key.AsGuid) {
return ssENCFDIType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCFDIType.FillFromOther((IRecord) other.AttributeGet(IdCFDIType));
}
} // RC_2cc384f6ee3d7a04dad15c303ce7a7a4
/// <summary>
/// RecordList type <code>CFDITypeRecordList</code> that represents a record list of
///  <code>CFDIType</code>
/// </summary>
public partial class RL_80d693ca1b09bd1e3d2fe45d7043a540 : GenericRecordList<RC_2cc384f6ee3d7a04dad15c303ce7a7a4>, IEnumerable, IEnumerator {

protected override RC_2cc384f6ee3d7a04dad15c303ce7a7a4 GetElementDefaultValue() {
return new RC_2cc384f6ee3d7a04dad15c303ce7a7a4();
}

public T[] ToArray<T>(Func<RC_2cc384f6ee3d7a04dad15c303ce7a7a4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_80d693ca1b09bd1e3d2fe45d7043a540 recordList, Func<RC_2cc384f6ee3d7a04dad15c303ce7a7a4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_80d693ca1b09bd1e3d2fe45d7043a540(RC_2cc384f6ee3d7a04dad15c303ce7a7a4[] array) {
  RL_80d693ca1b09bd1e3d2fe45d7043a540 result = new RL_80d693ca1b09bd1e3d2fe45d7043a540();
result.InnerFromArray(array);
    return result;
}

public static RL_80d693ca1b09bd1e3d2fe45d7043a540 ToList<T>(T[] array, Func <T, RC_2cc384f6ee3d7a04dad15c303ce7a7a4> converter) {
  RL_80d693ca1b09bd1e3d2fe45d7043a540 result = new RL_80d693ca1b09bd1e3d2fe45d7043a540();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_80d693ca1b09bd1e3d2fe45d7043a540 FromRestList<T>(RestList<T> restList, Func <T, RC_2cc384f6ee3d7a04dad15c303ce7a7a4> converter) {
  RL_80d693ca1b09bd1e3d2fe45d7043a540 result = new RL_80d693ca1b09bd1e3d2fe45d7043a540();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_80d693ca1b09bd1e3d2fe45d7043a540() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2cc384f6ee3d7a04dad15c303ce7a7a4> NewList() {
return new RL_80d693ca1b09bd1e3d2fe45d7043a540();
}


} // RL_80d693ca1b09bd1e3d2fe45d7043a540
}

