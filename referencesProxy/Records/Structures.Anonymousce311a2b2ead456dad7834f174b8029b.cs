namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Kxoxzq0ubUWteDTxdLgCmw)
///  <code>RC_1549014643485d6d2fd0ba657a6961ac</code> that represents <code>AuditRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: AuditRecord
public partial struct RC_1549014643485d6d2fd0ba657a6961ac : ITypedRecord<RC_1549014643485d6d2fd0ba657a6961ac> {
internal static readonly GlobalObjectKey IdAudit = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RgFJFUhDbV0v0LplemlhrA");

public EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord ssENAudit;


public static implicit operator EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord( RC_1549014643485d6d2fd0ba657a6961ac r) {
return r.ssENAudit;
}

public static implicit operator RC_1549014643485d6d2fd0ba657a6961ac (EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord r) {
RC_1549014643485d6d2fd0ba657a6961ac res = new RC_1549014643485d6d2fd0ba657a6961ac ();
res.ssENAudit = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAudit.ChangedAttributes = value;
}
get {
    return ssENAudit.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1549014643485d6d2fd0ba657a6961ac() {
OptimizedAttributes = null;
ssENAudit = new EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAudit.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAudit.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAudit.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAudit.Read( r, ref index);
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
public void ReadIM(RC_1549014643485d6d2fd0ba657a6961ac r) {
this = r;
}


public static bool operator == (RC_1549014643485d6d2fd0ba657a6961ac a, RC_1549014643485d6d2fd0ba657a6961ac b) {
if (a.ssENAudit != b.ssENAudit) return false;
return true;
}

public static bool operator != (RC_1549014643485d6d2fd0ba657a6961ac a, RC_1549014643485d6d2fd0ba657a6961ac b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1549014643485d6d2fd0ba657a6961ac)) return false;
return (this == (RC_1549014643485d6d2fd0ba657a6961ac)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAudit.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAudit.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAudit.InternalRecursiveSave();
}


public RC_1549014643485d6d2fd0ba657a6961ac Duplicate() {
RC_1549014643485d6d2fd0ba657a6961ac t;
t.ssENAudit = (EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord)this.ssENAudit.Duplicate();
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
if (head == "audit") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Audit")) variable.Value = ssENAudit; else variable.Optimized = true;
variable.SetFieldName("audit");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAudit.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAudit.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAudit) {
return ssENAudit;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAudit.Key.AsGuid) {
return ssENAudit;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAudit.FillFromOther((IRecord) other.AttributeGet(IdAudit));
}
} // RC_1549014643485d6d2fd0ba657a6961ac
/// <summary>
/// RecordList type <code>AuditRecordList</code> that represents a record list of <code>Audit</code>
/// </summary>
public partial class RL_51e6f14cc57ecfb6b24eb9fb0624d5e0 : GenericRecordList<RC_1549014643485d6d2fd0ba657a6961ac>, IEnumerable, IEnumerator {

protected override RC_1549014643485d6d2fd0ba657a6961ac GetElementDefaultValue() {
return new RC_1549014643485d6d2fd0ba657a6961ac();
}

public T[] ToArray<T>(Func<RC_1549014643485d6d2fd0ba657a6961ac, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_51e6f14cc57ecfb6b24eb9fb0624d5e0 recordList, Func<RC_1549014643485d6d2fd0ba657a6961ac, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_51e6f14cc57ecfb6b24eb9fb0624d5e0(RC_1549014643485d6d2fd0ba657a6961ac[] array) {
  RL_51e6f14cc57ecfb6b24eb9fb0624d5e0 result = new RL_51e6f14cc57ecfb6b24eb9fb0624d5e0();
result.InnerFromArray(array);
    return result;
}

public static RL_51e6f14cc57ecfb6b24eb9fb0624d5e0 ToList<T>(T[] array, Func <T, RC_1549014643485d6d2fd0ba657a6961ac> converter) {
  RL_51e6f14cc57ecfb6b24eb9fb0624d5e0 result = new RL_51e6f14cc57ecfb6b24eb9fb0624d5e0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_51e6f14cc57ecfb6b24eb9fb0624d5e0 FromRestList<T>(RestList<T> restList, Func <T, RC_1549014643485d6d2fd0ba657a6961ac> converter) {
  RL_51e6f14cc57ecfb6b24eb9fb0624d5e0 result = new RL_51e6f14cc57ecfb6b24eb9fb0624d5e0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_51e6f14cc57ecfb6b24eb9fb0624d5e0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1549014643485d6d2fd0ba657a6961ac> NewList() {
return new RL_51e6f14cc57ecfb6b24eb9fb0624d5e0();
}


} // RL_51e6f14cc57ecfb6b24eb9fb0624d5e0
}

