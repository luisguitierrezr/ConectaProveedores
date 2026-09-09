namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (0VuJ14bhOEmYQElxlhgYig)
///  <code>RC_ec6369e0ab5a663741bcc7fd811dc6b4</code> that represent
/// s <code>AuditPublicStrucRecord</code> <p>Description: </p>
/// </summary>
// Name: AuditPublicStrucRecord
public partial struct RC_ec6369e0ab5a663741bcc7fd811dc6b4 : ITypedRecord<RC_ec6369e0ab5a663741bcc7fd811dc6b4> {
internal static readonly GlobalObjectKey IdAuditPublicStruc = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4Glj7FqrN2ZBvMf9gR3GtA");

public ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure ssSTAuditPublicStruc;


public static implicit operator ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure( RC_ec6369e0ab5a663741bcc7fd811dc6b4 r) {
return r.ssSTAuditPublicStruc;
}

public static implicit operator RC_ec6369e0ab5a663741bcc7fd811dc6b4 (ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure r) {
RC_ec6369e0ab5a663741bcc7fd811dc6b4 res = new RC_ec6369e0ab5a663741bcc7fd811dc6b4 ();
res.ssSTAuditPublicStruc = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_ec6369e0ab5a663741bcc7fd811dc6b4() {
OptimizedAttributes = null;
ssSTAuditPublicStruc = new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure();
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
    ssSTAuditPublicStruc.OptimizedAttributes = value[0];
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
ssSTAuditPublicStruc.Read( r, ref index);
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
public void ReadIM(RC_ec6369e0ab5a663741bcc7fd811dc6b4 r) {
this = r;
}


public static bool operator == (RC_ec6369e0ab5a663741bcc7fd811dc6b4 a, RC_ec6369e0ab5a663741bcc7fd811dc6b4 b) {
if (a.ssSTAuditPublicStruc != b.ssSTAuditPublicStruc) return false;
return true;
}

public static bool operator != (RC_ec6369e0ab5a663741bcc7fd811dc6b4 a, RC_ec6369e0ab5a663741bcc7fd811dc6b4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ec6369e0ab5a663741bcc7fd811dc6b4)) return false;
return (this == (RC_ec6369e0ab5a663741bcc7fd811dc6b4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAuditPublicStruc.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAuditPublicStruc.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAuditPublicStruc.InternalRecursiveSave();
}


public RC_ec6369e0ab5a663741bcc7fd811dc6b4 Duplicate() {
RC_ec6369e0ab5a663741bcc7fd811dc6b4 t;
t.ssSTAuditPublicStruc = (ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure)this.ssSTAuditPublicStruc.Duplicate();
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
if (head == "auditpublicstruc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AuditPublicStruc")) variable.Value = ssSTAuditPublicStruc; else variable.Optimized = true;
variable.SetFieldName("auditpublicstruc");
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
if (key == IdAuditPublicStruc) {
return ssSTAuditPublicStruc;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAuditPublicStruc.Key.AsGuid) {
return ssSTAuditPublicStruc;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAuditPublicStruc.FillFromOther((IRecord) other.AttributeGet(IdAuditPublicStruc));
}
} // RC_ec6369e0ab5a663741bcc7fd811dc6b4
/// <summary>
/// RecordList type <code>AuditPublicStrucRecordList</code> that represents a record list of
///  <code>AuditPublicStruc</code>
/// </summary>
public partial class RL_85881a57b50eee0d434455eadd45483a : GenericRecordList<RC_ec6369e0ab5a663741bcc7fd811dc6b4>, IEnumerable, IEnumerator {

protected override RC_ec6369e0ab5a663741bcc7fd811dc6b4 GetElementDefaultValue() {
return new RC_ec6369e0ab5a663741bcc7fd811dc6b4();
}

public T[] ToArray<T>(Func<RC_ec6369e0ab5a663741bcc7fd811dc6b4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_85881a57b50eee0d434455eadd45483a recordList, Func<RC_ec6369e0ab5a663741bcc7fd811dc6b4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_85881a57b50eee0d434455eadd45483a(RC_ec6369e0ab5a663741bcc7fd811dc6b4[] array) {
  RL_85881a57b50eee0d434455eadd45483a result = new RL_85881a57b50eee0d434455eadd45483a();
result.InnerFromArray(array);
    return result;
}

public static RL_85881a57b50eee0d434455eadd45483a ToList<T>(T[] array, Func <T, RC_ec6369e0ab5a663741bcc7fd811dc6b4> converter) {
  RL_85881a57b50eee0d434455eadd45483a result = new RL_85881a57b50eee0d434455eadd45483a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_85881a57b50eee0d434455eadd45483a FromRestList<T>(RestList<T> restList, Func <T, RC_ec6369e0ab5a663741bcc7fd811dc6b4> converter) {
  RL_85881a57b50eee0d434455eadd45483a result = new RL_85881a57b50eee0d434455eadd45483a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_85881a57b50eee0d434455eadd45483a() : base() {
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
protected override OSList<RC_ec6369e0ab5a663741bcc7fd811dc6b4> NewList() {
return new RL_85881a57b50eee0d434455eadd45483a();
}


} // RL_85881a57b50eee0d434455eadd45483a
}

