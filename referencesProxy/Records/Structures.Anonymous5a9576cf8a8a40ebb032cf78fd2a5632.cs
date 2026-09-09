namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (z3aVWoqK60CwMs94_SpWMg)
///  <code>RC_8408d1f105e1ca6f4773d6dc694bb3bb</code> that represent
/// s <code>OnPremisesExtensionAttributeRecord</code> <p>Description: </p>
/// </summary>
// Name: OnPremisesExtensionAttributeRecord
public partial struct RC_8408d1f105e1ca6f4773d6dc694bb3bb : ITypedRecord<RC_8408d1f105e1ca6f4773d6dc694bb3bb> {
internal static readonly GlobalObjectKey IdOnPremisesExtensionAttribute = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8dEIhOEFb8pHc9bcaUuzuw");

public ST_f5088e93197e1d0bc0e83e9a247c44fbStructure ssSTOnPremisesExtensionAttribute;


public static implicit operator ST_f5088e93197e1d0bc0e83e9a247c44fbStructure( RC_8408d1f105e1ca6f4773d6dc694bb3bb r) {
return r.ssSTOnPremisesExtensionAttribute;
}

public static implicit operator RC_8408d1f105e1ca6f4773d6dc694bb3bb (ST_f5088e93197e1d0bc0e83e9a247c44fbStructure r) {
RC_8408d1f105e1ca6f4773d6dc694bb3bb res = new RC_8408d1f105e1ca6f4773d6dc694bb3bb ();
res.ssSTOnPremisesExtensionAttribute = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8408d1f105e1ca6f4773d6dc694bb3bb() {
OptimizedAttributes = null;
ssSTOnPremisesExtensionAttribute = new ST_f5088e93197e1d0bc0e83e9a247c44fbStructure();
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
    ssSTOnPremisesExtensionAttribute.OptimizedAttributes = value[0];
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
ssSTOnPremisesExtensionAttribute.Read( r, ref index);
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
public void ReadIM(RC_8408d1f105e1ca6f4773d6dc694bb3bb r) {
this = r;
}


public static bool operator == (RC_8408d1f105e1ca6f4773d6dc694bb3bb a, RC_8408d1f105e1ca6f4773d6dc694bb3bb b) {
if (a.ssSTOnPremisesExtensionAttribute != b.ssSTOnPremisesExtensionAttribute) return false;
return true;
}

public static bool operator != (RC_8408d1f105e1ca6f4773d6dc694bb3bb a, RC_8408d1f105e1ca6f4773d6dc694bb3bb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8408d1f105e1ca6f4773d6dc694bb3bb)) return false;
return (this == (RC_8408d1f105e1ca6f4773d6dc694bb3bb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOnPremisesExtensionAttribute.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOnPremisesExtensionAttribute.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOnPremisesExtensionAttribute.InternalRecursiveSave();
}


public RC_8408d1f105e1ca6f4773d6dc694bb3bb Duplicate() {
RC_8408d1f105e1ca6f4773d6dc694bb3bb t;
t.ssSTOnPremisesExtensionAttribute = (ST_f5088e93197e1d0bc0e83e9a247c44fbStructure)this.ssSTOnPremisesExtensionAttribute.Duplicate();
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
if (head == "onpremisesextensionattribute") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OnPremisesExtensionAttribute")) variable.Value = ssSTOnPremisesExtensionAttribute; else variable.Optimized = true;
variable.SetFieldName("onpremisesextensionattribute");
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
if (key == IdOnPremisesExtensionAttribute) {
return ssSTOnPremisesExtensionAttribute;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOnPremisesExtensionAttribute.Key.AsGuid) {
return ssSTOnPremisesExtensionAttribute;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOnPremisesExtensionAttribute.FillFromOther((IRecord) other.AttributeGet(IdOnPremisesExtensionAttribute));
}
} // RC_8408d1f105e1ca6f4773d6dc694bb3bb
/// <summary>
/// RecordList type <code>OnPremisesExtensionAttributeRecordList</code> that represents a record list
///  of <code>OnPremisesExtensionAttribute</code>
/// </summary>
public partial class RL_9035ce2701850dacf4422060adf3e1b8 : GenericRecordList<RC_8408d1f105e1ca6f4773d6dc694bb3bb>, IEnumerable, IEnumerator {

protected override RC_8408d1f105e1ca6f4773d6dc694bb3bb GetElementDefaultValue() {
return new RC_8408d1f105e1ca6f4773d6dc694bb3bb();
}

public T[] ToArray<T>(Func<RC_8408d1f105e1ca6f4773d6dc694bb3bb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9035ce2701850dacf4422060adf3e1b8 recordList, Func<RC_8408d1f105e1ca6f4773d6dc694bb3bb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9035ce2701850dacf4422060adf3e1b8(RC_8408d1f105e1ca6f4773d6dc694bb3bb[] array) {
  RL_9035ce2701850dacf4422060adf3e1b8 result = new RL_9035ce2701850dacf4422060adf3e1b8();
result.InnerFromArray(array);
    return result;
}

public static RL_9035ce2701850dacf4422060adf3e1b8 ToList<T>(T[] array, Func <T, RC_8408d1f105e1ca6f4773d6dc694bb3bb> converter) {
  RL_9035ce2701850dacf4422060adf3e1b8 result = new RL_9035ce2701850dacf4422060adf3e1b8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9035ce2701850dacf4422060adf3e1b8 FromRestList<T>(RestList<T> restList, Func <T, RC_8408d1f105e1ca6f4773d6dc694bb3bb> converter) {
  RL_9035ce2701850dacf4422060adf3e1b8 result = new RL_9035ce2701850dacf4422060adf3e1b8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9035ce2701850dacf4422060adf3e1b8() : base() {
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
protected override OSList<RC_8408d1f105e1ca6f4773d6dc694bb3bb> NewList() {
return new RL_9035ce2701850dacf4422060adf3e1b8();
}


} // RL_9035ce2701850dacf4422060adf3e1b8
}

