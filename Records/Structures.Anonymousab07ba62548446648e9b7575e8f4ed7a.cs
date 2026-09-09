namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (YroHq4RUZEaOm3V16PTteg)
///  <code>RC_923bce1cc861aeec3c8146d26c567e1f</code> that represent
/// s <code>MinuteDocumentTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: MinuteDocumentTypeRecord
public partial struct RC_923bce1cc861aeec3c8146d26c567e1f : ITypedRecord<RC_923bce1cc861aeec3c8146d26c567e1f> {
internal static readonly GlobalObjectKey IdMinuteDocumentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HM47kmHI7K48gUbSbFZ+Hw");

public ST_b2fd0f57faec93f17ef861f417f1cd5cStructure ssSTMinuteDocumentType;


public static implicit operator ST_b2fd0f57faec93f17ef861f417f1cd5cStructure( RC_923bce1cc861aeec3c8146d26c567e1f r) {
return r.ssSTMinuteDocumentType;
}

public static implicit operator RC_923bce1cc861aeec3c8146d26c567e1f (ST_b2fd0f57faec93f17ef861f417f1cd5cStructure r) {
RC_923bce1cc861aeec3c8146d26c567e1f res = new RC_923bce1cc861aeec3c8146d26c567e1f ();
res.ssSTMinuteDocumentType = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_923bce1cc861aeec3c8146d26c567e1f() {
OptimizedAttributes = null;
ssSTMinuteDocumentType = new ST_b2fd0f57faec93f17ef861f417f1cd5cStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTMinuteDocumentType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTMinuteDocumentType.Read( r, ref index);
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
public void ReadIM(RC_923bce1cc861aeec3c8146d26c567e1f r) {
this = r;
}


public static bool operator == (RC_923bce1cc861aeec3c8146d26c567e1f a, RC_923bce1cc861aeec3c8146d26c567e1f b) {
if (a.ssSTMinuteDocumentType != b.ssSTMinuteDocumentType) return false;
return true;
}

public static bool operator != (RC_923bce1cc861aeec3c8146d26c567e1f a, RC_923bce1cc861aeec3c8146d26c567e1f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_923bce1cc861aeec3c8146d26c567e1f)) return false;
return (this == (RC_923bce1cc861aeec3c8146d26c567e1f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTMinuteDocumentType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTMinuteDocumentType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTMinuteDocumentType.InternalRecursiveSave();
}


public RC_923bce1cc861aeec3c8146d26c567e1f Duplicate() {
RC_923bce1cc861aeec3c8146d26c567e1f t;
t.ssSTMinuteDocumentType = (ST_b2fd0f57faec93f17ef861f417f1cd5cStructure)this.ssSTMinuteDocumentType.Duplicate();
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
if (head == "minutedocumenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinuteDocumentType")) variable.Value = ssSTMinuteDocumentType; else variable.Optimized = true;
variable.SetFieldName("minutedocumenttype");
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
if (key == IdMinuteDocumentType) {
return ssSTMinuteDocumentType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMinuteDocumentType.Key.AsGuid) {
return ssSTMinuteDocumentType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTMinuteDocumentType.FillFromOther((IRecord) other.AttributeGet(IdMinuteDocumentType));
}
} // RC_923bce1cc861aeec3c8146d26c567e1f
/// <summary>
/// RecordList type <code>MinuteDocumentTypeRecordList</code> that represents a record list of
///  <code>MinuteDocumentType</code>
/// </summary>
public partial class RL_80cc4d44aff9adec93171482a140825a : GenericRecordList<RC_923bce1cc861aeec3c8146d26c567e1f>, IEnumerable, IEnumerator {

protected override RC_923bce1cc861aeec3c8146d26c567e1f GetElementDefaultValue() {
return new RC_923bce1cc861aeec3c8146d26c567e1f();
}

public T[] ToArray<T>(Func<RC_923bce1cc861aeec3c8146d26c567e1f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_80cc4d44aff9adec93171482a140825a recordList, Func<RC_923bce1cc861aeec3c8146d26c567e1f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_80cc4d44aff9adec93171482a140825a(RC_923bce1cc861aeec3c8146d26c567e1f[] array) {
  RL_80cc4d44aff9adec93171482a140825a result = new RL_80cc4d44aff9adec93171482a140825a();
result.InnerFromArray(array);
    return result;
}

public static RL_80cc4d44aff9adec93171482a140825a ToList<T>(T[] array, Func <T, RC_923bce1cc861aeec3c8146d26c567e1f> converter) {
  RL_80cc4d44aff9adec93171482a140825a result = new RL_80cc4d44aff9adec93171482a140825a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_80cc4d44aff9adec93171482a140825a FromRestList<T>(RestList<T> restList, Func <T, RC_923bce1cc861aeec3c8146d26c567e1f> converter) {
  RL_80cc4d44aff9adec93171482a140825a result = new RL_80cc4d44aff9adec93171482a140825a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_80cc4d44aff9adec93171482a140825a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_923bce1cc861aeec3c8146d26c567e1f> NewList() {
return new RL_80cc4d44aff9adec93171482a140825a();
}


} // RL_80cc4d44aff9adec93171482a140825a
}

