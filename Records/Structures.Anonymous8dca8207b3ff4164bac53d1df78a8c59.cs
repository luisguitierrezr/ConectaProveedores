namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (B4LKjf+zZEG6xT0d94qMWQ)
///  <code>RC_1ea63146d7f1d969afc206832e751192</code> that represents <code>BooleanTypesRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: BooleanTypesRecord
public partial struct RC_1ea63146d7f1d969afc206832e751192 : ITypedRecord<RC_1ea63146d7f1d969afc206832e751192> {
internal static readonly GlobalObjectKey IdBooleanTypes = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RjGmHvHXadmvwgaDLnURkg");

public EN_1e2af88601c0491260411e1369eb104cEntityRecord ssENBooleanTypes;


public static implicit operator EN_1e2af88601c0491260411e1369eb104cEntityRecord( RC_1ea63146d7f1d969afc206832e751192 r) {
return r.ssENBooleanTypes;
}

public static implicit operator RC_1ea63146d7f1d969afc206832e751192 (EN_1e2af88601c0491260411e1369eb104cEntityRecord r) {
RC_1ea63146d7f1d969afc206832e751192 res = new RC_1ea63146d7f1d969afc206832e751192 ();
res.ssENBooleanTypes = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENBooleanTypes.ChangedAttributes = value;
}
get {
    return ssENBooleanTypes.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1ea63146d7f1d969afc206832e751192() {
OptimizedAttributes = null;
ssENBooleanTypes = new EN_1e2af88601c0491260411e1369eb104cEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENBooleanTypes.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENBooleanTypes.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENBooleanTypes.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENBooleanTypes.Read( r, ref index);
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
public void ReadIM(RC_1ea63146d7f1d969afc206832e751192 r) {
this = r;
}


public static bool operator == (RC_1ea63146d7f1d969afc206832e751192 a, RC_1ea63146d7f1d969afc206832e751192 b) {
if (a.ssENBooleanTypes != b.ssENBooleanTypes) return false;
return true;
}

public static bool operator != (RC_1ea63146d7f1d969afc206832e751192 a, RC_1ea63146d7f1d969afc206832e751192 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1ea63146d7f1d969afc206832e751192)) return false;
return (this == (RC_1ea63146d7f1d969afc206832e751192)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENBooleanTypes.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENBooleanTypes.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENBooleanTypes.InternalRecursiveSave();
}


public RC_1ea63146d7f1d969afc206832e751192 Duplicate() {
RC_1ea63146d7f1d969afc206832e751192 t;
t.ssENBooleanTypes = (EN_1e2af88601c0491260411e1369eb104cEntityRecord)this.ssENBooleanTypes.Duplicate();
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
if (head == "booleantypes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BooleanTypes")) variable.Value = ssENBooleanTypes; else variable.Optimized = true;
variable.SetFieldName("booleantypes");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENBooleanTypes.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENBooleanTypes.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdBooleanTypes) {
return ssENBooleanTypes;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBooleanTypes.Key.AsGuid) {
return ssENBooleanTypes;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENBooleanTypes.FillFromOther((IRecord) other.AttributeGet(IdBooleanTypes));
}
} // RC_1ea63146d7f1d969afc206832e751192
/// <summary>
/// RecordList type <code>BooleanTypesRecordList</code> that represents a record list of
///  <code>BooleanTypes</code>
/// </summary>
public partial class RL_8e0fc5c9e799d27970a97b6552ea83ed : GenericRecordList<RC_1ea63146d7f1d969afc206832e751192>, IEnumerable, IEnumerator {

protected override RC_1ea63146d7f1d969afc206832e751192 GetElementDefaultValue() {
return new RC_1ea63146d7f1d969afc206832e751192();
}

public T[] ToArray<T>(Func<RC_1ea63146d7f1d969afc206832e751192, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8e0fc5c9e799d27970a97b6552ea83ed recordList, Func<RC_1ea63146d7f1d969afc206832e751192, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8e0fc5c9e799d27970a97b6552ea83ed(RC_1ea63146d7f1d969afc206832e751192[] array) {
  RL_8e0fc5c9e799d27970a97b6552ea83ed result = new RL_8e0fc5c9e799d27970a97b6552ea83ed();
result.InnerFromArray(array);
    return result;
}

public static RL_8e0fc5c9e799d27970a97b6552ea83ed ToList<T>(T[] array, Func <T, RC_1ea63146d7f1d969afc206832e751192> converter) {
  RL_8e0fc5c9e799d27970a97b6552ea83ed result = new RL_8e0fc5c9e799d27970a97b6552ea83ed();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8e0fc5c9e799d27970a97b6552ea83ed FromRestList<T>(RestList<T> restList, Func <T, RC_1ea63146d7f1d969afc206832e751192> converter) {
  RL_8e0fc5c9e799d27970a97b6552ea83ed result = new RL_8e0fc5c9e799d27970a97b6552ea83ed();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8e0fc5c9e799d27970a97b6552ea83ed() : base() {
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
protected override OSList<RC_1ea63146d7f1d969afc206832e751192> NewList() {
return new RL_8e0fc5c9e799d27970a97b6552ea83ed();
}


} // RL_8e0fc5c9e799d27970a97b6552ea83ed
}

