namespace ssConectaProveedores {
/// <summary>
/// [Structure] DocumentExtrationDateRange (Z_qj_yTigkqi1Tv2NvSsng)
///  <code>ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure</code> that represent
/// s <code>DocumentExtrationDateRange</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationDateRange
public partial struct ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure : ITypedRecord<ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure> {
internal static readonly GlobalObjectKey IdDesde = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RNR59qFRhUaIncm4sa5I4w");
internal static readonly GlobalObjectKey IdHasta = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*m4xkRtccV02l8LBWigtwng");
internal static readonly GlobalObjectKey IdSpace = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1SqZNCVlhECCZ9W_cmAXqQ");
internal static readonly GlobalObjectKey IdDesde2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0Cfx5pWuV0K_AQLbtSVX3g");
internal static readonly GlobalObjectKey IdHasta2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oQTODb6d1ka6RmVsAztl0Q");

public string ssDesde;

public string ssHasta;

public string ssSpace;

public string ssDesde2;

public string ssHasta2;


public BitArray OptimizedAttributes;

public ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure() {
OptimizedAttributes = null;
ssDesde = "";
ssHasta = "";
ssSpace = "";
ssDesde2 = "";
ssHasta2 = "";
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
ssDesde = r.ReadText(index++, "DocumentExtrationDateRange.Desde", "");
ssHasta = r.ReadText(index++, "DocumentExtrationDateRange.Hasta", "");
ssSpace = r.ReadText(index++, "DocumentExtrationDateRange.Space", "");
ssDesde2 = r.ReadText(index++, "DocumentExtrationDateRange.Desde2", "");
ssHasta2 = r.ReadText(index++, "DocumentExtrationDateRange.Hasta2", "");
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
public void ReadIM(ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure r) {
this = r;
}


public static bool operator == (ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure a, ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure b) {
if (a.ssDesde != b.ssDesde) return false;
if (a.ssHasta != b.ssHasta) return false;
if (a.ssSpace != b.ssSpace) return false;
if (a.ssDesde2 != b.ssDesde2) return false;
if (a.ssHasta2 != b.ssHasta2) return false;
return true;
}

public static bool operator != (ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure a, ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure)) return false;
return (this == (ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDesde.GetHashCode()
 ^ ssHasta.GetHashCode()
 ^ ssSpace.GetHashCode()
 ^ ssDesde2.GetHashCode()
 ^ ssHasta2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure Duplicate() {
ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure t;
t.ssDesde = this.ssDesde;
t.ssHasta = this.ssHasta;
t.ssSpace = this.ssSpace;
t.ssDesde2 = this.ssDesde2;
t.ssHasta2 = this.ssHasta2;
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
if (head == "desde") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Desde")) variable.Value = ssDesde; else variable.Optimized = true;
} else if (head == "hasta") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Hasta")) variable.Value = ssHasta; else variable.Optimized = true;
} else if (head == "space") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Space")) variable.Value = ssSpace; else variable.Optimized = true;
} else if (head == "desde2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Desde2")) variable.Value = ssDesde2; else variable.Optimized = true;
} else if (head == "hasta2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Hasta2")) variable.Value = ssHasta2; else variable.Optimized = true;
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
if (key == IdDesde) {
return ssDesde;
}
if (key == IdHasta) {
return ssHasta;
}
if (key == IdSpace) {
return ssSpace;
}
if (key == IdDesde2) {
return ssDesde2;
}
if (key == IdHasta2) {
return ssHasta2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDesde.Key.AsGuid) {
return ssDesde;
}
if (attributeKey == IdHasta.Key.AsGuid) {
return ssHasta;
}
if (attributeKey == IdSpace.Key.AsGuid) {
return ssSpace;
}
if (attributeKey == IdDesde2.Key.AsGuid) {
return ssDesde2;
}
if (attributeKey == IdHasta2.Key.AsGuid) {
return ssHasta2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssDesde = (string) other.AttributeGet(IdDesde);
ssHasta = (string) other.AttributeGet(IdHasta);
ssSpace = (string) other.AttributeGet(IdSpace);
ssDesde2 = (string) other.AttributeGet(IdDesde2);
ssHasta2 = (string) other.AttributeGet(IdHasta2);
}
} // ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure
/// <summary>
/// RecordList type <code>DocumentExtrationDateRangeList</code> that represents a record list of
///  <code>DocumentExtrationDateRange</code>
/// </summary>
public partial class RL_2bb86364ced21bae0282491633838a55 : GenericRecordList<ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure>, IEnumerable, IEnumerator {

protected override ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure GetElementDefaultValue() {
return new ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure();
}

public T[] ToArray<T>(Func<ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2bb86364ced21bae0282491633838a55 recordList, Func<ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2bb86364ced21bae0282491633838a55(ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure[] array) {
  RL_2bb86364ced21bae0282491633838a55 result = new RL_2bb86364ced21bae0282491633838a55();
result.InnerFromArray(array);
    return result;
}

public static RL_2bb86364ced21bae0282491633838a55 ToList<T>(T[] array, Func <T, ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure> converter) {
  RL_2bb86364ced21bae0282491633838a55 result = new RL_2bb86364ced21bae0282491633838a55();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2bb86364ced21bae0282491633838a55 FromRestList<T>(RestList<T> restList, Func <T, ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure> converter) {
  RL_2bb86364ced21bae0282491633838a55 result = new RL_2bb86364ced21bae0282491633838a55();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2bb86364ced21bae0282491633838a55() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure> NewList() {
return new RL_2bb86364ced21bae0282491633838a55();
}


} // RL_2bb86364ced21bae0282491633838a55
}

