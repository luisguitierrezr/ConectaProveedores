namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PI_ITEM_SM_CECO (ior7YySug02UTu00M9slFA)
///  <code>ST_1241dbde99de907a27732884f6e65ab4Structure</code> that represent
/// s <code>PI_ITEM_SM_CECO</code> <p>Description: PI_ITEM_SM_CECO</p>
/// </summary>
// Name: PI_ITEM_SM_CECO
public partial struct ST_1241dbde99de907a27732884f6e65ab4Structure : ITypedRecord<ST_1241dbde99de907a27732884f6e65ab4Structure> {
internal static readonly GlobalObjectKey IdItem = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*lb7P_z1d9kGGCZNyo167mQ");

public RL_58f0d660c2772ea329be34fddf4b9ec9 ssItem;


public BitArray OptimizedAttributes;

public ST_1241dbde99de907a27732884f6e65ab4Structure() {
OptimizedAttributes = null;
ssItem = new RL_58f0d660c2772ea329be34fddf4b9ec9();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(ST_1241dbde99de907a27732884f6e65ab4Structure r) {
this = r;
}


public static bool operator == (ST_1241dbde99de907a27732884f6e65ab4Structure a, ST_1241dbde99de907a27732884f6e65ab4Structure b) {
if (a.ssItem != b.ssItem) return false;
return true;
}

public static bool operator != (ST_1241dbde99de907a27732884f6e65ab4Structure a, ST_1241dbde99de907a27732884f6e65ab4Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1241dbde99de907a27732884f6e65ab4Structure)) return false;
return (this == (ST_1241dbde99de907a27732884f6e65ab4Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssItem.InternalRecursiveSave();
}


public ST_1241dbde99de907a27732884f6e65ab4Structure Duplicate() {
ST_1241dbde99de907a27732884f6e65ab4Structure t;
t.ssItem = (RL_58f0d660c2772ea329be34fddf4b9ec9)this.ssItem.Duplicate();
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
if (head == "item") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Item")) variable.Value = ssItem; else variable.Optimized = true;
variable.SetFieldName("item");
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
if (key == IdItem) {
return ssItem;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdItem.Key.AsGuid) {
return ssItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssItem = new RL_58f0d660c2772ea329be34fddf4b9ec9();
ssItem.FillFromOther((IOSList) other.AttributeGet(IdItem));
}
} // ST_1241dbde99de907a27732884f6e65ab4Structure
/// <summary>
/// RecordList type <code>PI_ITEM_SM_CECOList</code> that represents a record list of
///  <code>PI_ITEM_SM_CECO</code>
/// </summary>
public partial class RL_f8e82f041e8715c9840ae9536aedf1cc : GenericRecordList<ST_1241dbde99de907a27732884f6e65ab4Structure>, IEnumerable, IEnumerator {

protected override ST_1241dbde99de907a27732884f6e65ab4Structure GetElementDefaultValue() {
return new ST_1241dbde99de907a27732884f6e65ab4Structure();
}

public T[] ToArray<T>(Func<ST_1241dbde99de907a27732884f6e65ab4Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f8e82f041e8715c9840ae9536aedf1cc recordList, Func<ST_1241dbde99de907a27732884f6e65ab4Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f8e82f041e8715c9840ae9536aedf1cc(ST_1241dbde99de907a27732884f6e65ab4Structure[] array) {
  RL_f8e82f041e8715c9840ae9536aedf1cc result = new RL_f8e82f041e8715c9840ae9536aedf1cc();
result.InnerFromArray(array);
    return result;
}

public static RL_f8e82f041e8715c9840ae9536aedf1cc ToList<T>(T[] array, Func <T, ST_1241dbde99de907a27732884f6e65ab4Structure> converter) {
  RL_f8e82f041e8715c9840ae9536aedf1cc result = new RL_f8e82f041e8715c9840ae9536aedf1cc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f8e82f041e8715c9840ae9536aedf1cc FromRestList<T>(RestList<T> restList, Func <T, ST_1241dbde99de907a27732884f6e65ab4Structure> converter) {
  RL_f8e82f041e8715c9840ae9536aedf1cc result = new RL_f8e82f041e8715c9840ae9536aedf1cc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f8e82f041e8715c9840ae9536aedf1cc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1241dbde99de907a27732884f6e65ab4Structure> NewList() {
return new RL_f8e82f041e8715c9840ae9536aedf1cc();
}


} // RL_f8e82f041e8715c9840ae9536aedf1cc
}

