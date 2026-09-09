namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (0A5lxPjPlEKcc8_HJrzzyA)
///  <code>RC_fc0c28a94f4c81220c2f7cc24e1f448a</code> that represent
/// s <code>EmailNotificationRecord</code> <p>Description: </p>
/// </summary>
// Name: EmailNotificationRecord
public partial struct RC_fc0c28a94f4c81220c2f7cc24e1f448a : ITypedRecord<RC_fc0c28a94f4c81220c2f7cc24e1f448a> {
internal static readonly GlobalObjectKey IdEmailNotification = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qSgM_ExPIoEML3zCTh9Eig");

public ST_12668886130225cd5b17c72a6562dd7cStructure ssSTEmailNotification;


public static implicit operator ST_12668886130225cd5b17c72a6562dd7cStructure( RC_fc0c28a94f4c81220c2f7cc24e1f448a r) {
return r.ssSTEmailNotification;
}

public static implicit operator RC_fc0c28a94f4c81220c2f7cc24e1f448a (ST_12668886130225cd5b17c72a6562dd7cStructure r) {
RC_fc0c28a94f4c81220c2f7cc24e1f448a res = new RC_fc0c28a94f4c81220c2f7cc24e1f448a ();
res.ssSTEmailNotification = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_fc0c28a94f4c81220c2f7cc24e1f448a() {
OptimizedAttributes = null;
ssSTEmailNotification = new ST_12668886130225cd5b17c72a6562dd7cStructure();
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
    ssSTEmailNotification.OptimizedAttributes = value[0];
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
ssSTEmailNotification.Read( r, ref index);
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
public void ReadIM(RC_fc0c28a94f4c81220c2f7cc24e1f448a r) {
this = r;
}


public static bool operator == (RC_fc0c28a94f4c81220c2f7cc24e1f448a a, RC_fc0c28a94f4c81220c2f7cc24e1f448a b) {
if (a.ssSTEmailNotification != b.ssSTEmailNotification) return false;
return true;
}

public static bool operator != (RC_fc0c28a94f4c81220c2f7cc24e1f448a a, RC_fc0c28a94f4c81220c2f7cc24e1f448a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fc0c28a94f4c81220c2f7cc24e1f448a)) return false;
return (this == (RC_fc0c28a94f4c81220c2f7cc24e1f448a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEmailNotification.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEmailNotification.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEmailNotification.InternalRecursiveSave();
}


public RC_fc0c28a94f4c81220c2f7cc24e1f448a Duplicate() {
RC_fc0c28a94f4c81220c2f7cc24e1f448a t;
t.ssSTEmailNotification = (ST_12668886130225cd5b17c72a6562dd7cStructure)this.ssSTEmailNotification.Duplicate();
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
if (head == "emailnotification") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EmailNotification")) variable.Value = ssSTEmailNotification; else variable.Optimized = true;
variable.SetFieldName("emailnotification");
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
if (key == IdEmailNotification) {
return ssSTEmailNotification;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEmailNotification.Key.AsGuid) {
return ssSTEmailNotification;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEmailNotification.FillFromOther((IRecord) other.AttributeGet(IdEmailNotification));
}
} // RC_fc0c28a94f4c81220c2f7cc24e1f448a
/// <summary>
/// RecordList type <code>EmailNotificationRecordList</code> that represents a record list of
///  <code>EmailNotification</code>
/// </summary>
public partial class RL_f56196e27a07ea8a96d51460ab27d86e : GenericRecordList<RC_fc0c28a94f4c81220c2f7cc24e1f448a>, IEnumerable, IEnumerator {

protected override RC_fc0c28a94f4c81220c2f7cc24e1f448a GetElementDefaultValue() {
return new RC_fc0c28a94f4c81220c2f7cc24e1f448a();
}

public T[] ToArray<T>(Func<RC_fc0c28a94f4c81220c2f7cc24e1f448a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f56196e27a07ea8a96d51460ab27d86e recordList, Func<RC_fc0c28a94f4c81220c2f7cc24e1f448a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f56196e27a07ea8a96d51460ab27d86e(RC_fc0c28a94f4c81220c2f7cc24e1f448a[] array) {
  RL_f56196e27a07ea8a96d51460ab27d86e result = new RL_f56196e27a07ea8a96d51460ab27d86e();
result.InnerFromArray(array);
    return result;
}

public static RL_f56196e27a07ea8a96d51460ab27d86e ToList<T>(T[] array, Func <T, RC_fc0c28a94f4c81220c2f7cc24e1f448a> converter) {
  RL_f56196e27a07ea8a96d51460ab27d86e result = new RL_f56196e27a07ea8a96d51460ab27d86e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f56196e27a07ea8a96d51460ab27d86e FromRestList<T>(RestList<T> restList, Func <T, RC_fc0c28a94f4c81220c2f7cc24e1f448a> converter) {
  RL_f56196e27a07ea8a96d51460ab27d86e result = new RL_f56196e27a07ea8a96d51460ab27d86e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f56196e27a07ea8a96d51460ab27d86e() : base() {
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
protected override OSList<RC_fc0c28a94f4c81220c2f7cc24e1f448a> NewList() {
return new RL_f56196e27a07ea8a96d51460ab27d86e();
}


} // RL_f56196e27a07ea8a96d51460ab27d86e
}

