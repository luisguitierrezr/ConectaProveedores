namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (GHrSCwF_7UCWuX9TgAmTSg)
///  <code>RC_070998dc6b3dc951b52d8108550fe380</code> that represents <code>DirectionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DirectionRecord
public partial struct RC_070998dc6b3dc951b52d8108550fe380 : ITypedRecord<RC_070998dc6b3dc951b52d8108550fe380> {
internal static readonly GlobalObjectKey IdDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3JgJBz1rUcm1LYEIVQ_jgA");

public EN_50814454e481dd1773c2250bc248da5eEntityRecord ssENDirection;


public static implicit operator EN_50814454e481dd1773c2250bc248da5eEntityRecord( RC_070998dc6b3dc951b52d8108550fe380 r) {
return r.ssENDirection;
}

public static implicit operator RC_070998dc6b3dc951b52d8108550fe380 (EN_50814454e481dd1773c2250bc248da5eEntityRecord r) {
RC_070998dc6b3dc951b52d8108550fe380 res = new RC_070998dc6b3dc951b52d8108550fe380 ();
res.ssENDirection = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDirection.ChangedAttributes = value;
}
get {
    return ssENDirection.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_070998dc6b3dc951b52d8108550fe380() {
OptimizedAttributes = null;
ssENDirection = new EN_50814454e481dd1773c2250bc248da5eEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDirection.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDirection.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDirection.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDirection.Read( r, ref index);
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
public void ReadIM(RC_070998dc6b3dc951b52d8108550fe380 r) {
this = r;
}


public static bool operator == (RC_070998dc6b3dc951b52d8108550fe380 a, RC_070998dc6b3dc951b52d8108550fe380 b) {
if (a.ssENDirection != b.ssENDirection) return false;
return true;
}

public static bool operator != (RC_070998dc6b3dc951b52d8108550fe380 a, RC_070998dc6b3dc951b52d8108550fe380 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_070998dc6b3dc951b52d8108550fe380)) return false;
return (this == (RC_070998dc6b3dc951b52d8108550fe380)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDirection.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDirection.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDirection.InternalRecursiveSave();
}


public RC_070998dc6b3dc951b52d8108550fe380 Duplicate() {
RC_070998dc6b3dc951b52d8108550fe380 t;
t.ssENDirection = (EN_50814454e481dd1773c2250bc248da5eEntityRecord)this.ssENDirection.Duplicate();
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
if (head == "direction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Direction")) variable.Value = ssENDirection; else variable.Optimized = true;
variable.SetFieldName("direction");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDirection.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDirection.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDirection) {
return ssENDirection;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDirection.Key.AsGuid) {
return ssENDirection;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDirection.FillFromOther((IRecord) other.AttributeGet(IdDirection));
}
} // RC_070998dc6b3dc951b52d8108550fe380
/// <summary>
/// RecordList type <code>DirectionRecordList</code> that represents a record list of
///  <code>Direction</code>
/// </summary>
public partial class RL_f6bc0d68163ce9d4c64ce162194bde5e : GenericRecordList<RC_070998dc6b3dc951b52d8108550fe380>, IEnumerable, IEnumerator {

protected override RC_070998dc6b3dc951b52d8108550fe380 GetElementDefaultValue() {
return new RC_070998dc6b3dc951b52d8108550fe380();
}

public T[] ToArray<T>(Func<RC_070998dc6b3dc951b52d8108550fe380, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f6bc0d68163ce9d4c64ce162194bde5e recordList, Func<RC_070998dc6b3dc951b52d8108550fe380, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f6bc0d68163ce9d4c64ce162194bde5e(RC_070998dc6b3dc951b52d8108550fe380[] array) {
  RL_f6bc0d68163ce9d4c64ce162194bde5e result = new RL_f6bc0d68163ce9d4c64ce162194bde5e();
result.InnerFromArray(array);
    return result;
}

public static RL_f6bc0d68163ce9d4c64ce162194bde5e ToList<T>(T[] array, Func <T, RC_070998dc6b3dc951b52d8108550fe380> converter) {
  RL_f6bc0d68163ce9d4c64ce162194bde5e result = new RL_f6bc0d68163ce9d4c64ce162194bde5e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f6bc0d68163ce9d4c64ce162194bde5e FromRestList<T>(RestList<T> restList, Func <T, RC_070998dc6b3dc951b52d8108550fe380> converter) {
  RL_f6bc0d68163ce9d4c64ce162194bde5e result = new RL_f6bc0d68163ce9d4c64ce162194bde5e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f6bc0d68163ce9d4c64ce162194bde5e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_070998dc6b3dc951b52d8108550fe380> NewList() {
return new RL_f6bc0d68163ce9d4c64ce162194bde5e();
}


} // RL_f6bc0d68163ce9d4c64ce162194bde5e
}

